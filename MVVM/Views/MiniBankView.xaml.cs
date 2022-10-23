namespace MiniBank.MVVM.Views;

public partial class MiniBankView : ContentPage
{
	public MiniBankView()
	{
		InitializeComponent();
	}

	private void WithdrawBtn_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new Withdraw());
    }

    private void DepositBtn_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Deposit());
	}

	private void ConvertBtn_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Convert());
	}

	private void BalanceBtn_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new Balance());
    }
}