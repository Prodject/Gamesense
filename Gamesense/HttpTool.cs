using System;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

using Gamesense.Models;

namespace Gamesense
{
	public class HttpTool
	{
		HttpClient _client;

		public HttpTool(CoreProps cprops)
		{
			_client = new HttpClient() { BaseAddress = new Uri(cprops.BaseAddress) };
		}

		public async Task<HttpResponseMessage> GetAsync(string path)
		{
			return await _client.GetAsync(path);
		}

		public async Task<string> PostAsync<T>(string path, T data)
		{
			var request = new HttpRequestMessage(HttpMethod.Post, _client.BaseAddress + path);
			using (var content = new StringContent(JsonConvert.SerializeObject(data), System.Text.Encoding.UTF8, "application/json"))
			{
				request.Content = content;

				var response = await _client.SendAsync(request).ConfigureAwait(false);
				//response.EnsureSuccessStatusCode();
				return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
			}
		}
	}
}
