using BeställningsApp5.Models;
using BeställningsApp5.ViewModels;
using System.Net;
using System.Xml.Linq;

namespace BeställningsApp5.Views;

public partial class FiskMenu : ContentPage
{
	public FiskMenu()
	{
		InitializeComponent();
        BindingContext = new ViewModels.ProductViewModel().TheMenProducts;
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