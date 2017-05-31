using System.Collections.Generic;

using System.Timers;

using Gamesense.Handlers;
using Gamesense.Handlers.Types;

using static System.Console;

namespace Gamesense.Sample
{
	public class GradientExampleWithCustomZones : IExample
	{
		public string ExampleName => "Gradient progressbar with custom zones";

		public void Run()
		{
			var gg = new GamesenseClient("FPS_SAMPLE", "FPS Sample", IconColor.Red);

			// Register game
			Util.Print($"# Registering game: {gg.Game.GameDisplayName} ({gg.Game.GameName})");
			Util.Input(gg.RegisterGame());

			// Bind event
			Util.Print("# Binding events");
			Util.Input(gg.BindEvent("TEST_EVENT", 0, 100, EventIcon.Backpack, new List<BaseHandler>
			{
				new GradientHandler(Constants.DEVICE_TYPE_KEYBOARD, new List<int>{
					HIDKeys.W,
					HIDKeys.A,
					HIDKeys.S,
					HIDKeys.D
				}, Constants.ILLUMINATION_MODE_COLOR, new Gradient(new RGB(255,0,0), new RGB(0,255,0)))
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
