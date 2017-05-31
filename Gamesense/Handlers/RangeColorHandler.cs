using System.Collections.Generic;

using Gamesense.Handlers.BaseHandlers;
using Gamesense.Handlers.Types;

namespace Gamesense.Handlers
{
	public class RangeColorHandler : BaseColorHandler
	{
		public RangeColorHandler(string deviceType, string zone, string mode, ColorRange crange, IRate rate = null)
		{
			DeviceType = deviceType;
			Zone = zone;
			Mode = mode;
			Color = crange;
			Rate = rate;
		}

		public RangeColorHandler(string deviceType, List<int> customZoneKeys, string mode, ColorRange crange, IRate rate = null)
		{
			DeviceType = deviceType;
			CustomZoneKeys = customZoneKeys;
			Mode = mode;
			Color = crange;
			Rate = rate;
		}
	}
}
