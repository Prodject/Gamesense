using Newtonsoft.Json;

namespace Gamesense.Models
{
	public class Game
	{
		[JsonProperty(PropertyName = "game")]
		public string GameName { get; set; }

		[JsonProperty(PropertyName = "game_display_name")]
		public string GameDisplayName { get; set; }
		
		[JsonProperty(PropertyName = "icon_color_id")]
		public int IconColorId { get; set; }
	}
}
