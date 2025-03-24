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
		if (e.SelectedItem == null)
			return;

		// ตรวจสอบประเภทของข้อมูล
		if (e.SelectedItem is string selectedSubject)
		{
			var viewModel = BindingContext as RecordViewModel;
			if (viewModel != null)
			{
				await viewModel.DeleteSubject(selectedSubject);
			}
		}

	// รีเซ็ตการเลือกรายการ
	((ListView)sender).SelectedItem = null;
	}
}