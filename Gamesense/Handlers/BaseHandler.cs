using System.Collections.Generic;

using Newtonsoft.Json;

using Gamesense.Handlers.Types;

namespace Gamesense.Handlers
{
	public abstract class BaseHandler
	{
		[JsonProperty(PropertyName = "device-type")]
		public string DeviceType;
		[JsonProperty(PropertyName = "zone")]
		public string Zone;
		[JsonProperty(PropertyName = "mode")]
		public string Mode;
		[JsonProperty(PropertyName = "custom-zone-keys")]
		public List<int> CustomZoneKeys;
		[JsonProperty(PropertyName = "rate")]
		public IRate Rate;

		public bool ShouldSerializeZone()
		{
			if (Zone != null && CustomZoneKeys != null)
			{
				throw new GamesenseException("Zone and CustomZoneKeys are exclusive, but both have been given");
			}

			return CustomZoneKeys == null;
		}

		public bool ShouldSerializeCustomZoneKeys()
		{
			if (Zone != null && CustomZoneKeys != null)
			{
				throw new GamesenseException("Zone and CustomZoneKeys are exclusive, but both have been given");
			}

			return Zone == null;
		}

		public bool ShouldSerializeRate()
		{
			return Rate != null;
		}
	}
}
