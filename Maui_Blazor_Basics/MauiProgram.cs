using Microsoft.AspNetCore.Components.WebView.Maui;
using Maui_Blazor_Basics.Data;
using Maui_Blazor_Basics.Services;

namespace Maui_Blazor_Basics;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		
		builder.Services.AddSingleton<WeatherForecastService>();
		builder.Services.AddSingleton<IDeezerSearchService, DeezerSearchService>();

		return builder.Build();
	}
}
