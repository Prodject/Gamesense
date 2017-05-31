using Newtonsoft.Json;
using Gamesense.Handlers.Types;

namespace Gamesense.Handlers.Types
{
	public class ColorRange : ColorType
	{
		[JsonProperty(PropertyName = "low")]
		public int Low;
		[JsonProperty(PropertyName = "high")]
		public int High;
		[JsonProperty(PropertyName = "color")]
		public ColorType Color;
	}
}
