using System.Collections.Generic;

using Newtonsoft.Json;
using Gamesense.Handlers.Types;

namespace Gamesense.Handlers.Types
{
	public interface IRate { }

	public class RateStatic : IRate
	{
		[JsonProperty(PropertyName = "frequency")]
		public int Frequency;
		[JsonProperty(PropertyName = "repeat_limit")]
		public int RepeatLimit;

		public RateStatic() { }
		public RateStatic(int freq, int repeatLimit)
		{
			Frequency = freq;
			RepeatLimit = repeatLimit;
		}
	}

	public class RateRange : IRate
	{
		[JsonProperty(PropertyName = "frequency")]
		public List<Frequency> Frequency;
		[JsonProperty(PropertyName = "repeat_limit")]
		public List<RepeatLimit> RepeatLimit;

		public RateRange() { }
		public RateRange(List<Frequency> frequencies, List<RepeatLimit> repeatLimits)
		{
			Frequency = frequencies;
			RepeatLimit = repeatLimits;
		}
	}

	public class Frequency
	{
		[JsonProperty(PropertyName = "low")]
		public int Low;
		[JsonProperty(PropertyName = "high")]
		public int High;
		[JsonProperty(PropertyName = "frequency")]
		public int FrequencyValue;

		public Frequency() { }
		public Frequency(int low, int high, int freq)
		{
			Low = low;
			High = high;
			FrequencyValue = freq;
		}
	}

	public class RepeatLimit
	{
		[JsonProperty(PropertyName = "low")]
		public int Low;
		[JsonProperty(PropertyName = "high")]
		public int High;
		[JsonProperty(PropertyName = "repeat_limit")]
		public int RepeatLimitValue;

		public RepeatLimit() { }
		public RepeatLimit(int low, int high, int repeatLimit)
		{
			Low = low;
			High = high;
			RepeatLimitValue = repeatLimit;
		}
	}
}
