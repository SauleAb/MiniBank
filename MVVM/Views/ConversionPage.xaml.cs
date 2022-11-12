using Microsoft.VisualBasic;
using MiniBank.MVVM.ViewModels;
using MiniBank.MVVM.Models;

namespace MiniBank.MVVM.Views;

public partial class Convert : ContentPage
{
	public Convert()
	{
		InitializeComponent();
        BindingContext = new ConversionsViewModel();
    }

    private async void ConvertBtn_Clicked(object sender, EventArgs e)
    {
        var currentVM = (ConversionsViewModel)BindingContext;
        var amount = currentVM.Convert().ToString();
        await DisplayAlert("Converted Amount:", amount, "Ok");
        await Navigation.PopToRootAsync();
    }
}