namespace SFDC;

public partial class ClockOut : ContentPage
{
	public ClockOut()
	{
		InitializeComponent();
	}
    async void BackToMain(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}