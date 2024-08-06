using Microsoft.Maui.Controls;

namespace NavigationApp;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

	private async void OnBackButtonClicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}