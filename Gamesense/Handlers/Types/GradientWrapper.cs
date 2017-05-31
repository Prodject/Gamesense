using Newtonsoft.Json;

namespace Gamesense.Handlers.Types
{
	public class GradientWrapper : ColorType
	{
		[JsonProperty(PropertyName = "gradient")] public Gradient Gradient;
		public GradientWrapper(Gradient gr)
		{
			Gradient = gr;
		}
	}
}
