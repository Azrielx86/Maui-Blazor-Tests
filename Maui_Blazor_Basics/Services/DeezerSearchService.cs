using Maui_Blazor_Basics.Models;
using Maui_Blazor_Basics.Services;
using System.Text.Json;

namespace Maui_Blazor_Basics.Services
{
	internal class DeezerSearchService : IDeezerSearchService
	{
		const string URL = "https://api.deezer.com/search?q={0}";

		public async Task<DeezerSearchModel> Get(string Query)
		{
			HttpClient httpClient = new();
			var response = await httpClient.GetAsync(String.Format(URL, Query.ToLower()));
			var content = await response.Content.ReadAsStringAsync();
			var deezerSearch = JsonSerializer.Deserialize<DeezerSearchModel>(content);
			return deezerSearch;
		}
	}
}
