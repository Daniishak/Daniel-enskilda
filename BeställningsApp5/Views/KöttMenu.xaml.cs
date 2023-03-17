using BeställningsApp5.Models;

namespace BeställningsApp5.Views;

public partial class KöttMenu : ContentPage
{
	public KöttMenu()
	{
		InitializeComponent();
        BindingContext = new ViewModels.ProductViewModel().TheJewelryProducts;
    }
    private async void Läggtill(object sender, EventArgs e)
    {
        var button = sender as Button;
        var produkter = button?.BindingContext as Product;

        if (produkter != null)
        {
            VarukorgSingleton.Instance.AddItem(produkter);
        }
    }

    private async void OnVarukorgClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ShoppingCart());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}