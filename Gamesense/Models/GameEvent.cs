using System.Collections.Generic;

using Newtonsoft.Json;

namespace Gamesense.Models
{
	public class GameEvent
	{
		[JsonProperty(PropertyName = "game")]
		public string GameName;

		[JsonProperty(PropertyName = "event")]
		public string Event;

		[JsonProperty(PropertyName = "data")]
		public Dictionary<string, object> Data;

		public GameEvent()
		{
			Data = new Dictionary<string, object>();
		}
	}
}
