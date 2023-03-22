using Oxide.Core.Plugins;
using Oxide.Core.Libraries.Covalence;

namespace Oxide.Plugins
{
    [Info("Forecast", "BloodSkin", "1.0.0")]
    class Forecast : CovalencePlugin
    {
        [Command("forecast")]
        private void ForecastCommand(IPlayer player, string command, string[] args)
        {
            var report = ConsoleSystem.Run(ConsoleSystem.Option.Server.Quiet(), "weather.report");
            player.Reply(report);
        }
    }
}
