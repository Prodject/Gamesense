using Newtonsoft.Json;

namespace Gamesense.Handlers.Types
{
	public class RGB : ColorType
	{
		[JsonProperty(PropertyName = "red")] public byte Red;
		[JsonProperty(PropertyName = "green")] public byte Green;
		[JsonProperty(PropertyName = "blue")] public byte Blue;

		public RGB(byte r, byte g, byte b)
		{
			Red = r;
			Green = g;
			Blue = b;
		}
	}
}
