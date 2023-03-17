using System.ComponentModel;

namespace BeställningsApp5.Views;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    private async void OnKottClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new KöttMenu());
    }
    private async void OnVegClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VegMenu());
    }
    private async void OnFiskClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FiskMenu());
    }
    private async void OnElectronicClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new electronics());
    }

    private async void OnVarukorgClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ShoppingCart());
    }
}