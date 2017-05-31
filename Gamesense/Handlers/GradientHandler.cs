using System.Collections.Generic;

using Gamesense.Handlers.BaseHandlers;
using Gamesense.Handlers.Types;

namespace Gamesense.Handlers
{
	public class GradientHandler : BaseColorHandler
	{
		public GradientHandler(string deviceType, string zone, string mode, Gradient gradient, IRate rate = null)
		{
			DeviceType = deviceType;
			Zone = zone;
			Mode = mode;
			Color = new GradientWrapper(gradient);
			Rate = rate;
		}

		public GradientHandler(string deviceType, List<int> customZoneKeys, string mode, Gradient gradient, IRate rate = null)
		{
			DeviceType = deviceType;
			CustomZoneKeys = customZoneKeys;
			Mode = mode;
			Color = new GradientWrapper(gradient);
			Rate = rate;
		}
	}
}
