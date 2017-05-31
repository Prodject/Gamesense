using System;
using Gamesense.Handlers;
using Gamesense.Handlers.Types;

using static System.Console;

namespace Gamesense.Sample
{
	public class PerKeyExample : IExample
	{
		public string ExampleName => "Per-Key";

		public void Run()
		{
			var gg = new GamesenseClient("PERKEY_EXAMPLE", "Per Key Example", (int)IconColor.Red);

			// Register game
			Util.Print($"# Registering game: {gg.Game.GameDisplayName} ({gg.Game.GameName})");
			Util.Input(gg.RegisterGame());

			// Bind event
			Util.Print("# Binding events");
			Util.Input(gg.BindEvent("MOVEMENT_KEYS", 0, 1, (int)EventIcon.Compass, new System.Collections.Generic.List<BaseHandler>
			{
				new StaticColorHandler(Constants.DEVICE_TYPE_KEYBOARD, Constants.ZONE_PER_KEY_W, Constants.ILLUMINATION_MODE_COLOR, new RGB(255,255,255)),
				new StaticColorHandler(Constants.DEVICE_TYPE_KEYBOARD, Constants.ZONE_PER_KEY_A, Constants.ILLUMINATION_MODE_COLOR, new RGB(255,255,255)),
				new StaticColorHandler(Constants.DEVICE_TYPE_KEYBOARD, Constants.ZONE_PER_KEY_S, Constants.ILLUMINATION_MODE_COLOR, new RGB(255,255,255)),
				new StaticColorHandler(Constants.DEVICE_TYPE_KEYBOARD, Constants.ZONE_PER_KEY_D, Constants.ILLUMINATION_MODE_COLOR, new RGB(255,255,255)),
				new StaticColorHandler(Constants.DEVICE_TYPE_KEYBOARD, Constants.ZONE_PER_KEY_R, Constants.ILLUMINATION_MODE_COLOR, new RGB(255,0,0))
			}));

			// Update event
			Util.Print("# Sending key bindigs");
			Util.Input(gg.SendGameEvent("MOVEMENT_KEYS", new System.Collections.Generic.Dictionary<string, object>
			{
				{ "value", 1 }
			}));

			ReadKey(true);

			// Remove event
			Util.Print("# 4. Removing registrations");

			// Remove game
			Util.Input(gg.RemoveGame());
			ReadKey(true);
		}
	}
}
