using Oxide.Core.Plugins;
using Oxide.Core.Libraries.Covalence;
using System.Linq;

namespace Oxide.Plugins
{
    [Info("Weather Report", "BloodSkin", "1.0.4")]
    class WeatherReport : CovalencePlugin
    {
        [Command("weather")]
        private void WeatherCommand(IPlayer player, string command, string[] args)
        {
            var report = ConsoleSystem.Run(ConsoleSystem.Option.Server.Quiet(), "weather.report");
            var lines = report.Split('\n');
            var firstLineParts = lines[0].Split('|');
            var currentWeather = firstLineParts[1].Trim();
            var forecast = firstLineParts[2].Trim();
            player.Reply($"<color=#9999ff>Current Weather:</color> {currentWeather}");
			player.Reply($"<color=#9999ff>Forecast:</color> {forecast}");
        }
    }
}
