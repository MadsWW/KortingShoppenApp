using KortingShoppenApp.Constants;
using KortingShoppenApp.ViewModels;
using KortingShoppenApp.Views;

namespace KortingShoppenApp;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.UsePrism(prism => prism.RegisterTypes(container =>
			{
				container.RegisterForNavigation<SettingsView, SettingsViewModel>(KnownNavigationPages.Settings);
			}));



		return builder.Build();


	}

	public static void Test()
	{
#if __ANDROID__
		//Microsoft.Maui.Handlers.ViewHandler.ViewMapper = (View, Handler) => { };

#endif
	}
}
