using System;
using System.Collections.Generic;
using System.Linq;

namespace Gamesense.Sample
{
	public static class Samples
	{
		public static void Main()
		{
			var type = typeof(IExample);
			var types = AppDomain.CurrentDomain.GetAssemblies()
				.SelectMany(s => s.GetTypes())
				.Where(p => type.IsAssignableFrom(p) && p.IsInterface == false);


			var examples = new List<IExample>();
			foreach (var c in types)
			{
				examples.Add((IExample)Activator.CreateInstance(c));
			}

			for (int i = 0; i < examples.Count; i++)
			{
				Console.WriteLine($"{i}: {examples[i].ExampleName}");
			}
			Console.WriteLine("99: Exit");
			Console.WriteLine();
			Console.Write("Input: ");

			string input = Console.ReadLine();
			bool valid = false;
			int choice = -1;

			while (valid == false)
			{
				if (int.TryParse(input, out choice) == false)
				{
					Console.WriteLine("Invalid number entered");
					Console.Write("Input: ");
					input = Console.ReadLine();
					continue;
				}

				if (choice > examples.Count && choice != 99)
				{
					Console.WriteLine("There is no such example");
					Console.Write("Input: ");
					input = Console.ReadLine();
					continue;
				}

				valid = true;
			}

			if (choice == 99)
			{
				Environment.Exit(0);
			}

			Console.Clear();
			examples[choice].Run();
		}
	}
}
