using Newtonsoft.Json;

namespace Gamesense.Handlers.Types
{
	public class Gradient : ColorType
	{
		[JsonProperty(PropertyName = "zero")] public RGB Zero;
		[JsonProperty(PropertyName = "hundred")] public RGB Hundred;

		public Gradient(RGB zero, RGB hundred)
		{
			Zero = zero;
			Hundred = hundred;
		}
	}
}
