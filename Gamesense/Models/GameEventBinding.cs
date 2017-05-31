using System.Collections.Generic;

using Newtonsoft.Json;

using Gamesense.Handlers;

namespace Gamesense.Models
{
	public class GameEventBinding : GameEventRegistration
	{
		[JsonProperty(PropertyName = "handlers")]
		public List<BaseHandler> Handlers;
	}
}
