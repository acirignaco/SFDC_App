namespace SFDC;

public partial class ClockIn : ContentPage
{
	public ClockIn()
	{
		InitializeComponent();
	}
    async void BackToMain(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}