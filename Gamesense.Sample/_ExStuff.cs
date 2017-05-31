using System;

namespace Gamesense.Sample
{
	public class NumberOscilator
	{
		public int Min { get; private set; }
		public int Max { get; private set; }
		public int Current { get; private set; }

		OscDir Direction;

		public NumberOscilator(int min, int max)
		{
			Min = min;
			Max = max;
			Current = 0;
			Direction = OscDir.Up;
		}

		public void Update()
		{
			if (Current >= Max)
			{
				Direction = OscDir.Down;
			}

			if (Current <= Min)
			{
				Direction = OscDir.Up;
			}

			if (Direction == OscDir.Up)
			{
				Current++;
			}
			else
			{
				Current--;
			}
		}

		enum OscDir { Up, Down }
	}

	public static class Util
	{
		public static void Print(string msg)
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(msg);
		}

		public static void Input(string msg)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(msg);
		}
	}

	public interface IExample
	{
		string ExampleName { get; }
		void Run();
	}
}
