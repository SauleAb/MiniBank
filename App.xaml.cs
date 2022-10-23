using MiniBank.MVVM.Views;

namespace MiniBank;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MiniBankView());
	}
}
