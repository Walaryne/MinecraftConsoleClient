using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
namespace MinecraftClient.ChatBots
{
    /// <summary>
    /// Runs a list of commands
    /// </summary>

    public class Script : ChatBot
    {
        private string file;
        private string[] lines = new string[0];
        private string[] args = new string[0];
        private int sleepticks = 10;
        private int nextline;
        private string owner;
        private bool csharp;
        private Thread thread;
        private ManualResetEvent tpause;
        private Dictionary<string, object> localVars;

        public Script(string filename)
        {
            ParseArguments(filename);
        }

        public Script(string filename, string ownername, Dictionary<string, object> localVars)
            : this(filename)
        {
            owner = ownername;
            this.localVars = localVars;
        }

        private void ParseArguments(string argstr)
        {
            var args = new List<string>();
            var str = new StringBuilder();

            var escape = false;
            var quotes = false;

            foreach (char c in argstr)
            {
                if (escape)
                {
                    if (c != '"')
                        str.Append('\\');
                    str.Append(c);
                    escape = false;
                }
                else
                {
                    if (c == '\\')
                        escape = true;
                    else if (c == '"')
                        quotes = !quotes;
                    else if (c == ' ' && !quotes)
                    {
                        if (str.Length > 0)
                            args.Add(str.ToString());
                        str.Clear();
                    }
                    else str.Append(c);
                }
            }

            if (str.Length > 0)
                args.Add(str.ToString());

            if (args.Count > 0)
            {
                file = args[0];
                args.RemoveAt(0);
                this.args = args.ToArray();
            }
            else file = "";
        }

        public static bool LookForScript(ref string filename)
        {
            //Automatically look in subfolders and try to add ".txt" file extension
            char dir_slash = Program.isUsingMono ? '/' : '\\';
            string[] files = {
                filename,
                filename + ".txt",
                filename + ".cs",
                "scripts" + dir_slash + filename,
                "scripts" + dir_slash + filename + ".txt",
                "scripts" + dir_slash + filename + ".cs",
                "config" + dir_slash + filename,
                "config" + dir_slash + filename + ".txt",
                "config" + dir_slash + filename + ".cs",
            };

            foreach (string possible_file in files)
            {
                if (File.Exists(possible_file))
                {
                    filename = possible_file;
                    return true;
                }
            }

            if (Settings.DebugMessages)
            {
                var caller = "Script";
                try
                {
                    var frame = new StackFrame(1);
                    MethodBase method = frame.GetMethod();
                    Type type = method.DeclaringType;
                    caller = type.Name;
                }
                catch { }
                ConsoleIO.WriteLineFormatted(Translations.Get("bot.script.not_found", caller, filename));
            }

            return false;
        }

        public override void Initialize()
        {
            //Load the given file from the startup parameters
            if (LookForScript(ref file))
            {
                lines = File.ReadAllLines(file, Encoding.UTF8);
                csharp = file.EndsWith(".cs");
                thread = null;

                if (!String.IsNullOrEmpty(owner))
                    SendPrivateMessage(owner, Translations.Get("bot.script.pm.loaded", file));
            }
            else
            {
                LogToConsoleTranslated("bot.script.file_not_found", Path.GetFullPath(file));

                if (!String.IsNullOrEmpty(owner))
                    SendPrivateMessage(owner, Translations.Get("bot.script.file_not_found", file));
                
                UnloadBot(); //No need to keep the bot active
            }
        }

        public override void Update()
        {
            if (csharp) //C# compiled script
            {
                //Initialize thread on first update
                if (thread == null)
                {
                    tpause = new ManualResetEvent(false);
                    thread = new Thread(() =>
                    {
                        try
                        {
                            CSharpRunner.Run(this, tpause, lines, args, localVars);
                        }
                        catch (CSharpException e)
                        {
                            string errorMessage = Translations.Get("bot.script.fail", file, e.ExceptionType);
                            LogToConsole(errorMessage);
                            if (owner != null)
                                SendPrivateMessage(owner, errorMessage);
                            LogToConsole(e.InnerException);
                        }
                    });
                    thread.Start();
                }

                //Let the thread run for a short span of time
                if (thread != null)
                {
                    tpause.Set();
                    tpause.Reset();
                    if (!thread.IsAlive)
                        UnloadBot();
                }
            }
            else //Classic MCC script interpreter
            {
                if (sleepticks > 0) { sleepticks--; }
                else
                {
                    if (nextline < lines.Length) //Is there an instruction left to interpret?
                    {
                        string instruction_line = lines[nextline].Trim(); // Removes all whitespaces at start and end of current line
                        nextline++; //Move the cursor so that the next time the following line will be interpreted

                        if (instruction_line.Length > 1)
                        {
                            if (instruction_line[0] != '#' && instruction_line[0] != '/' && instruction_line[1] != '/')
                            {
                                instruction_line = Settings.ExpandVars(instruction_line, localVars);
                                string instruction_name = instruction_line.Split(' ')[0];
                                switch (instruction_name.ToLower())
                                {
                                    case "wait":
                                        var ticks = 10;
                                        try
                                        {
                                            ticks = Convert.ToInt32(instruction_line.Substring(5, instruction_line.Length - 5));
                                        }
                                        catch { }
                                        sleepticks = ticks;
                                        break;
                                    default:
                                        if (!PerformInternalCommand(instruction_line))
                                        {
                                            Update(); //Unknown command : process next line immediately
                                        }
                                        else if (instruction_name.ToLower() != "log") { LogToConsole(instruction_line); }
                                        break;
                                }
                            }
                            else { Update(); } //Comment: process next line immediately
                        }
                    }
                    else
                    {
                        //No more instructions to interpret
                        UnloadBot();
                    }
                }
            }
        }
    }
}
