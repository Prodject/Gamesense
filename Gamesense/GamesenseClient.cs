using System.IO;
using System.Collections.Generic;
using System.Timers;

using Gamesense.Models;
using Gamesense.Handlers;
using Gamesense.Handlers.Types;

namespace Gamesense
{
	public class GamesenseClient
	{
		public Game Game { get; private set; }
		public CoreProps CoreProps { get; private set; }
		public bool SSE3Found { get; private set; }

		HttpTool http;
		Timer heartBeatTimer;

		public GamesenseClient(string gameName, string gameDisplayName, IconColor iconColor) : this(gameName, gameDisplayName, (int)iconColor) { }
		public GamesenseClient(string gameName, string gameDisplayName, int iconColorId)
		{
			Game = new Game
			{
				GameName = gameName,
				GameDisplayName = gameDisplayName,
				IconColorId = iconColorId
			};

			string cpPath = Path.Combine(System.Environment.GetEnvironmentVariable("PROGRAMDATA"), "SteelSeries", "SteelSeries Engine 3", "coreProps.json");

			if (File.Exists(cpPath))
			{
				SSE3Found = true;

				using (var r = new StreamReader(cpPath))
				{
					CoreProps = Newtonsoft.Json.JsonConvert.DeserializeObject<CoreProps>(r.ReadToEnd());
				}

				http = new HttpTool(CoreProps);
				heartBeatTimer = new Timer(10000);
				heartBeatTimer.Elapsed += (s, e) => SendHeartBeat();
			}
			else
			{
				// TODO: friendlier check instead of exception
				throw new GamesenseException("SSE3 could not be found, might not be installed");
			}
		}

		/// <summary>
		/// Enables/disables the automatic sending of heartbeats
		/// </summary>
		/// <param name="enable">if set to <c>true</c> [enable].</param>
		public void SetAutoHeartBeat(bool enable)
		{
			heartBeatTimer.Enabled = enable;
		}

		/// <summary>
		/// Manually send a single heartbeat to SSE3
		/// </summary>
		/// <returns>JSON response string from SSE3</returns>
		public string SendHeartBeat()
		{
			return http.PostAsync("game_heartbeat", new { game = Game.GameName }).Result;
		}

		/// <summary>
		/// Registers the game with SSE3. This is not required, but makes sure the users will see a 
		/// user friendly game name and a custom colored icon in the SSE3 interface
		/// </summary>
		/// <returns>JSON response string from SSE3</returns>
		public string RegisterGame()
		{
			return http.PostAsync("game_metadata", Game).Result;
		}

		/// <summary>
		/// Removes the game. Removing a game will also remove all registered events/bindings for this game. 
		/// Events/bindings added through a golisp file will not be removed unless you remove the file as well. 
		/// You can use <seealso cref="RemoveGoLispHandler"/> for this.
		/// </summary>
		/// <returns>JSON response string from SSE3</returns>
		public string RemoveGame()
		{
			return http.PostAsync("remove_game", new { game = Game.GameName }).Result;
		}

		/// <summary>
		/// Registers a event so the user can customize it. No default values will be provided (Use the BindEvent method for this)
		/// </summary>
		/// <param name="eventName">Name of the event.</param>
		/// <param name="minValue">The minimum value.</param>
		/// <param name="maxValue">The maximum value.</param>
		/// <param name="iconId">The icon identifier.</param>
		/// <returns>JSON response string from SSE3</returns>
		public string RegisterEvent(string eventName, int minValue, int maxValue, EventIcon iconId)
		{
			return RegisterEvent(eventName, minValue, maxValue, (int)iconId);
		}

		/// <summary>
		/// Registers a event so the user can customize it. No default values will be provided (Use the BindEvent method for this)
		/// </summary>
		/// <param name="eventName">Name of the event.</param>
		/// <param name="minValue">The minimum value.</param>
		/// <param name="maxValue">The maximum value.</param>
		/// <param name="iconId">The icon identifier.</param>
		/// <returns>JSON response string from SSE3</returns>
		public string RegisterEvent(string eventName, int minValue, int maxValue, int iconId)
		{
			var evt = new GameEventRegistration
			{
				GameName = Game.GameName,
				Event = eventName,
				MinValue = minValue,
				MaxValue = maxValue,
				IconId = iconId
			};

			return http.PostAsync("register_game_event", evt).Result;
		}

		public string BindEvent(string eventName, int minValue, int maxValue, EventIcon iconId, List<BaseHandler> handlers)
		{
			return BindEvent(eventName, minValue, maxValue, (int)iconId, handlers);
		}

		public string BindEvent(string eventName, int minValue, int maxValue, int iconId, List<BaseHandler> handlers)
		{
			var evt = new GameEventBinding
			{
				GameName = Game.GameName,
				Event = eventName,
				MinValue = minValue,
				MaxValue = maxValue,
				IconId = iconId,
				Handlers = handlers
			};

			return http.PostAsync("bind_game_event", evt).Result;
		}

		public string SendGameEvent(string eventName, Dictionary<string, object> data)
		{
			var evt = new GameEvent
			{
				GameName = Game.GameName,
				Event = eventName,
				Data = data
			};

			return http.PostAsync("game_event", evt).Result;
		}

		public string RemoveEvent(string eventName)
		{
			return http.PostAsync("remove_game_event", new { game = Game.GameName, @event = eventName }).Result;
		}

		// === GOLISP THINGS ==================================================================================		
		/// <summary>
		/// Load a piece of golisp code
		/// </summary>
		/// <param name="lispCode">The GoLisp code.</param>
		/// <returns></returns>
		public string LoadGoLispHandler(string lispCode)
		{
			return http.PostAsync("load_golisp_handlers", new { game = Game.GameName, golisp = lispCode }).Result;
		}

		/// <summary>
		/// Copies the go lisp handler the appropriate folder.
		/// </summary>
		/// <param name="sourcePath">The source path.</param>
		/// <exception cref="GamesenseException">
		/// Something went wrong with the copying of the .lsp file. 
		/// Source lsp file could not be found or GoLisp handler copy failed
		/// </exception>
		public void CopyGoLispHandler(string sourcePath)
		{
			if (File.Exists(sourcePath) == false)
			{
				throw new GamesenseException("Source lsp file could not be found");
			}

			string dest = Path.Combine(System.Environment.GetEnvironmentVariable("PROGRAMDATA"), "SteelSeries", "SteelSeries Engine 3", "haX0rBindings", $"{Game.GameName}.lsp");
			File.Copy(sourcePath, dest);

			if (File.Exists(dest) == false)
			{
				throw new GamesenseException("GoLisp handler copy failed");
			}
		}

		/// <summary>
		/// Removes the GoLisp handler.
		/// </summary>
		/// <returns>True if the filewas deleted</returns>
		public bool RemoveGoLispHandler()
		{
			string dest = Path.Combine(System.Environment.GetEnvironmentVariable("PROGRAMDATA"), "SteelSeries", "SteelSeries Engine 3", "haX0rBindings", $"{Game.GameName}.lsp");

			if (File.Exists(dest))
			{
				File.Delete(dest);
				return true;
			}

			return false;
		}
	}
}
