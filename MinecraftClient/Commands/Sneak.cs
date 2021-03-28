using System.Collections.Generic;
using MinecraftClient.Protocol;
namespace MinecraftClient.Commands
{
    public class Sneak : Command
    {
        private bool sneaking;
        public override string CmdName { get { return "Sneak"; } }
        public override string CmdUsage { get { return "Sneak"; } }
        public override string CmdDesc { get { return "cmd.sneak.desc"; } }

        public override string Run(McClient handler, string command, Dictionary<string, object> localVars)
        {
            if (sneaking)
            {
                var result = handler.SendEntityAction(EntityActionType.StopSneaking);
                if (result)
                    sneaking = false;
                return  Translations.Get(result ? "cmd.sneak.off" : "general.fail");
            }
            else
            {
                var result = handler.SendEntityAction(EntityActionType.StartSneaking);
                if (result)
                    sneaking = true;
                return Translations.Get(result ? "cmd.sneak.on" : "general.fail");
            }
            
        }
    }
}