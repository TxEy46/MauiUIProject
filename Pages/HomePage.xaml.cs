namespace MauiProject.Pages;
using MauiProject.ViewModel;  // Add this line

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		BindingContext = new HomeViewModel();
	}
	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
	private void OnclickedProfile(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ProfilePage());		
	}
	private void OnclickedRegister(object sender, EventArgs e)
	{
		Navigation.PushAsync(new RecordPage());
	}
	private async void OnclickedLogout(object sender, EventArgs e)
	{
		bool answer = await DisplayAlert("แจ้งเตือน", "คุณต้องการออกจากระบบหรือไม่", "Ok", "Cancel");

		if (answer)
		{
			// ถ้าผู้ใช้เลือก "Ok" จะออกจากระบบ
			await Navigation.PopAsync(); // ปิดหน้าปัจจุบัน
		}
		else
		{
			// ถ้าผู้ใช้เลือก "Cancel" ไม่ทำอะไร
		}
	}

}