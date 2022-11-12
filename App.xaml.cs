using MiniBank.MVVM.Models;
using MiniBank.MVVM.Views;
using ProsperDaily.Repositories;

namespace MiniBank;

public partial class App : Application
{
	public static BaseRepository<Conversion>
		ConversionsRepo { get; private set; } 

	public App(BaseRepository<Conversion> _conversionsRepo)
	{
		InitializeComponent();

		ConversionsRepo = _conversionsRepo;

		MainPage = new NavigationPage(new MiniBankView());
	}
}
