using System;
using System.Collections.Generic;
using MinecraftClient.Mapping;
namespace MinecraftClient.Commands
{
    class Useblock : Command
    {
        public override string CmdName { get { return "useblock"; } }
        public override string CmdUsage { get { return "useblock <x> <y> <z>"; } }
        public override string CmdDesc { get { return "cmd.useblock.desc"; } }

        public override string Run(McClient handler, string command, Dictionary<string, object> localVars)
        {
            if (!handler.GetTerrainEnabled()) return Translations.Get("extra.terrainandmovement_required");
            if (hasArg(command))
            {
                string[] args = getArgs(command);
                if (args.Length >= 3)
                {
                    var x = Convert.ToInt32(args[0]);
                    var y = Convert.ToInt32(args[1]);
                    var z = Convert.ToInt32(args[2]);
                    handler.PlaceBlock(new Location(x, y, z), Direction.Down);
                }
                else { return GetCmdDescTranslated();  }
            }
            return GetCmdDescTranslated();
        }
    }
}
