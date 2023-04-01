

namespace MauiScientificCalculator.Views;

public partial class CalculatorPage : ContentPage
{
	public CalculatorPage()
	{
		InitializeComponent();
        //Initialize the view model
        BindingContext = new CalculatorPageViewModel();
    }
}