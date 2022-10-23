using MiniBank.MVVM.Models;

namespace MiniBank.MVVM.Views;

public partial class ConversionRequestView : ContentPage
{
	public ConversionRequestView()
	{
		InitializeComponent();
		var conversionRequest = new ConversionRequestView();
		BindingContext = conversionRequest;
	}

	private void ConvertBtn_Clicked(object sender, EventArgs e)
	{
		ConversionRequestView conversionRequestView = new ConversionRequestView
		{
			FromCurrency = FromCurrency.LoadFromXaml(FromCurrency.Text),
		};
	}

	private void FromCurrency_Completed(object sender, EventArgs e)
	{
        string text = ((Entry)sender).Text;
    }
}