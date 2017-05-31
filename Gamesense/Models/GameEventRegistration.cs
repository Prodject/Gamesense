using Newtonsoft.Json;

namespace Gamesense.Models
{
	public class GameEventRegistration
	{
		[JsonProperty(PropertyName = "game")]
		public string GameName;

		[JsonProperty(PropertyName = "event")]
		public string Event;

		[JsonProperty(PropertyName = "min_value")]
		public int MinValue;

		[JsonProperty(PropertyName = "max_value")]
		public int MaxValue;
		
		[JsonProperty(PropertyName = "icon_id")]
		public int IconId;
	}
}
