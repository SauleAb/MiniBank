namespace MiniBank.MVVM.Views;

public partial class MiniBankView : ContentPage
{
	public MiniBankView()
	{
		InitializeComponent();
	}

	private void WithdrawBtn_Clicked(object sender, EventArgs e)
	{

	}

	private void DepositBtn_Clicked(object sender, EventArgs e)
	{

	}

	private void ConvertBtn_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Convert());
	}

	private void BalanceBtn_Clicked(object sender, EventArgs e)
	{

	}
}