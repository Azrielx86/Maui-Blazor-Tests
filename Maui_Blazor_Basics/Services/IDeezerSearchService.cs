using Maui_Blazor_Basics.Models;

namespace Maui_Blazor_Basics.Services
{
	public interface IDeezerSearchService
	{
		public Task<DeezerSearchModel> Get(string Query);
	}
}
