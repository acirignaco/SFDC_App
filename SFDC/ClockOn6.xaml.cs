namespace SFDC;

public partial class ClockOn6 : ContentPage
{
	public ClockOn6()
	{
		InitializeComponent();
	}
    async void ClockOnHome(object sender, EventArgs e)
    {
        // Clock on log
        await Shell.Current.GoToAsync(nameof(MainPage));
    }

    async void BackToMain(object sender, EventArgs e)
    {
        // Just go home
        await Shell.Current.GoToAsync(nameof(MainPage));
    }
}