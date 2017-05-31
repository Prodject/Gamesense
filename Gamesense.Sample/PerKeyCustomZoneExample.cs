using System;
using System.Collections.Generic;
using Gamesense.Handlers;
using Gamesense.Handlers.Types;

using static System.Console;

namespace Gamesense.Sample
{
	public class PerKeyCustomZoneExample : IExample
	{
		public string ExampleName => "Per-Key with custom zones";

		public void Run()
		{
			var gg = new GamesenseClient("PERKEY_CUST_ZONE_EXAMPLE", "Per-Key example with custom zones", (int)IconColor.Red);

			// Register game
			Util.Print($"# Registering game: {gg.Game.GameDisplayName} ({gg.Game.GameName})");
			Util.Input(gg.RegisterGame());

			// Bind event
			Util.Print("# Binding events");
			Util.Input(gg.BindEvent("MOVEMENT_KEYS", 0, 1, (int)EventIcon.Compass, new List<BaseHandler>
			{
				// WASD
				new StaticColorHandler(Constants.DEVICE_TYPE_KEYBOARD, new List<int>{
					HIDKeys.W,
					HIDKeys.A,
					HIDKeys.S,
					HIDKeys.D
				}, Constants.ILLUMINATION_MODE_COLOR, new RGB(0,255,0)),

				// R, F, LShift
				new StaticColorHandler(Constants.DEVICE_TYPE_KEYBOARD, new List<int>
				{
					HIDKeys.R,
					HIDKeys.F,
					HIDKeys.LSHIFT
				}, Constants.ILLUMINATION_MODE_COLOR, new RGB(255,0,255))
			}));

			// Update event
			Util.Print("# Sending key bindigs");
			Util.Input(gg.SendGameEvent("MOVEMENT_KEYS", new Dictionary<string, object>
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
