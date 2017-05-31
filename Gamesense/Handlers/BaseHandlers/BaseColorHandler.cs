using Newtonsoft.Json;

using Gamesense.Handlers.Types;

namespace Gamesense.Handlers.BaseHandlers
{
	public abstract class BaseColorHandler : BaseHandler
	{
		[JsonProperty(PropertyName = "color")]
		public ColorType Color { get; set; }
	}
}
