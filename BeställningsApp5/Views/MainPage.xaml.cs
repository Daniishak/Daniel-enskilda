

namespace BeställningsApp5;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnBeställClicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new Views.Menu());
    }
}

