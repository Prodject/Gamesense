using System;

namespace Gamesense
{
	public class GamesenseException : Exception
	{
		public GamesenseException(string msg)
			: base(msg)
		{
		}
	}
}
