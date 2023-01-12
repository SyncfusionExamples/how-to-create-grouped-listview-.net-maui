using Syncfusion.Maui.Core.Hosting;

namespace ListViewGrouping;

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
				fonts.AddFont("Roboto-Regular.ttf", "Roboto");
			});
		builder.ConfigureSyncfusionCore();
		return builder.Build();
	}
}
