using KortingShoppenApp.Pages;

namespace KortingShoppenApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainTabbedPage();
	}
}
