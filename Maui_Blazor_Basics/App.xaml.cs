using Maui_Blazor_Basics.Services;

namespace Maui_Blazor_Basics;

public partial class App : Application
{
	public static PersonDBService PeopleRepo { get; private set; }
	public App(PersonDBService repo)
	{
		InitializeComponent();

		MainPage = new MainPage();

		PeopleRepo = repo;
	}
}
