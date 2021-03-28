namespace MinecraftClient.ChatBots
{
    /// <summary>
    /// Automatically logs you out when your HP reaches a certain threshold.
    /// </summary>
    public class AutoLogout : ChatBot
    {
        int hpThreshold;

        /// <summary>
        /// Automatically logs you out when your HP reaches a certain threshold.
        /// </summary>
        /// <param name="hpThreshold">Threshold for HP to cause an automatic logout.</param>
        public AutoLogout(int hpThreshold)
        {
            this.hpThreshold = hpThreshold;
        }

        public override void OnHealthUpdate(float health, int food)
        {
            if(health < hpThreshold && !((int) health == 0))
            {
                LogToConsole("Player HP below threshold, exiting MCC!");
                DisconnectAndExit();
            }
        }
    }
}
