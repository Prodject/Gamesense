namespace Gamesense.Models
{
	public class CoreProps
	{
		public string Address { get; set; }
		public string Encrypted_address { get; set; }

		public string BaseAddress { get { return "http://" + Address; } }
		public string GameEventAddress { get { return "http://" + Address + "/game_event"; } }
		public string HeartBeatAddress { get { return "http://" + Address + "/game_heartbeat"; } }
	}
}
