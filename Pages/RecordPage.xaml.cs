namespace MauiProject.Pages;
using MauiProject.ViewModel;

public partial class RecordPage : ContentPage
{
	public RecordPage()
	{
		InitializeComponent();
		BindingContext = new RecordViewModel();
	}
	private async void OnSelected(object sender, SelectedItemChangedEventArgs e)
	{
		// ตรวจสอบว่ามีรายวิชาที่ถูกเลือกหรือไม่
		if (e.SelectedItem == null)
			return;

		// ดึงรายวิชาที่ถูกเลือก
		string selectedSubject = e.SelectedItem as string;

		// เรียกใช้ DeleteSubject command
		var viewModel = BindingContext as RecordViewModel;
		if (viewModel != null)
		{
			await viewModel.DeleteSubject(selectedSubject);
		}

	// รีเซ็ตการเลือกรายวิชา
	((ListView)sender).SelectedItem = null;
	}
}