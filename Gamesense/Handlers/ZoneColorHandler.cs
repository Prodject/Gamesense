using System.Collections.Generic;

using Gamesense.Handlers.BaseHandlers;
using Gamesense.Handlers.Types;

namespace Gamesense.Handlers
{
	public class StaticColorHandler : BaseColorHandler
	{
		public StaticColorHandler(string deviceType, string zone, string mode, RGB color, IRate rate = null)
		{
			DeviceType = deviceType;
			Zone = zone;
			Mode = mode;
			Color = color;
			Rate = rate;
		}

		public StaticColorHandler(string deviceType, List<int> customZoneKeys, string mode, RGB color, IRate rate = null)
		{
			DeviceType = deviceType;
			CustomZoneKeys = customZoneKeys;
			Mode = mode;
			Color = color;
			Rate = rate;
		}
	}
}
