namespace MauiProject.Pages;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }
    private void Button_Clicked_Login(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        // ดึงข้อมูลจาก Entry ที่ผู้ใช้กรอก
        string name = entrytName.Text;
        string studentID = entryStudentID.Text;
        string email = entryEmail.Text;
        string password = entryPassword.Text;

        // ตรวจสอบข้อมูลที่กรอก
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(studentID) ||
            string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            await DisplayAlert("Error", "Please fill in all fields", "OK");
            return;
        }

        // ตัวอย่าง: ถ้าข้อมูลครบถ้วน จะแสดงข้อความลงทะเบียนสำเร็จ
        await DisplayAlert("Success", "Registration Completed", "OK");

        // หลังจากลงทะเบียนสำเร็จ สามารถทำการนำทางไปหน้าหลักหรือหน้าล็อกอิน
        // ตัวอย่าง: ถ้ามีการนำทางไปยังหน้าล็อกอิน
        await Navigation.PopAsync();
    }
}
