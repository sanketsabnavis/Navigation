using Microsoft.Maui.Controls;

namespace NavigationApp;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

	private async void OnNavigateButtonClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Page2());
	}
}