using System.Windows;
using BeställningsApp5.Models;
using BeställningsApp5.ViewModels;

namespace BeställningsApp5.Views;

public partial class electronics : ContentPage
{
    public electronics()
    {
        InitializeComponent();
        BindingContext = new ProductViewModel().TheElectronicProducts;

    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnVarukorgClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ShoppingCart());
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
}
