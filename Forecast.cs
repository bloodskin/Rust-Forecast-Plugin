using Oxide.Core.Plugins;
using Oxide.Core.Libraries.Covalence;
using System.Linq;

namespace Oxide.Plugins
{
    [Info("Forecast", "BloodSkin", "1.0.2")]
    class Forecast : CovalencePlugin
    {
        [Command("forecast")]
private void ForecastCommand(IPlayer player, string command, string[] args)
{
    var report = ConsoleSystem.Run(ConsoleSystem.Option.Server.Quiet(), "weather.report");
    var lines = report.Split('\n');
    var firstLineParts = lines[0].Split('|');
    player.Reply("<color=#9999ff>Todays Forecast:</color> " + firstLineParts[2].Trim());
}
    }
}
