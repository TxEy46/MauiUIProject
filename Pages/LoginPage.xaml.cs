namespace MauiProject.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		string email = entryEmail.Text;
		string password = entryPassword.Text;

		if (email == "admin" && password == "1234")
		{
			await Navigation.PushAsync(new HomePage());
		}
		else
		{
			await DisplayAlert("Error", "Invalid email or password", "OK");
		}
	}

	private async void Button_Clicked_Register(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterPage()); // Ensure RegisterPage.xaml exists
    }

	private void ForgetPasswordTapped(object sender, EventArgs e)
	{
		Console.WriteLine($"Email: {entryEmail.Text}, Password: {entryPassword.Text}");
	}
}
