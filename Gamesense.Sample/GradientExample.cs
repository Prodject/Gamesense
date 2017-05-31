using System.Timers;

using Gamesense.Handlers;
using Gamesense.Handlers.Types;

using static System.Console;

namespace Gamesense.Sample
{
	public class GradientExample : IExample
	{
		public string ExampleName => "Gradient progressbar";

		public void Run()
		{
			var gg = new GamesenseClient("FPS_SAMPLE", "FPS Sample", IconColor.Red);

			// Register game
			Util.Print($"# Registering game: {gg.Game.GameDisplayName} ({gg.Game.GameName})");
			Util.Input(gg.RegisterGame());

			// Bind event
			Util.Print("# Binding events");
			Util.Input(gg.BindEvent("TEST_EVENT", 0, 100, EventIcon.Backpack, new System.Collections.Generic.List<BaseHandler>
			{
				new GradientHandler(Constants.DEVICE_TYPE_KEYBOARD, Constants.ZONE_KEYBOARD_FKEYS, Constants.ILLUMINATION_MODE_PERCENT, new Gradient(new RGB(255,0,0), new RGB(0,255,0))),
				new GradientHandler(Constants.DEVICE_TYPE_KEYBOARD, Constants.ZONE_KEYBOARD_MACRO, Constants.ILLUMINATION_MODE_PERCENT, new Gradient(new RGB(255,0,0), new RGB(0,255,0))),
				new GradientHandler(Constants.DEVICE_TYPE_KEYBOARD, Constants.ZONE_KEYBOARD_NUMKEYS, Constants.ILLUMINATION_MODE_PERCENT, new Gradient(new RGB(255,0,0), new RGB(0,255,0)))
			}));

			// Update event
			var osc = new NumberOscilator(0, 100);
			var updateTimer = new Timer(10);
			updateTimer.Elapsed += (s, e) =>
			{
				osc.Update();
				Util.Input(gg.SendGameEvent("TEST_EVENT", new System.Collections.Generic.Dictionary<string, object>
				{
					{ "value", osc.Current }
				}));
			};
			updateTimer.Start();

			ReadKey(true);
			updateTimer.Stop();

			// Remove event
			Util.Print("# 4. Removing registrations");
			Util.Input(gg.RemoveEvent("TEST_EVENT"));
			// Remove game
			Util.Input(gg.RemoveGame());
			ReadKey(true);
		}
	}
}
