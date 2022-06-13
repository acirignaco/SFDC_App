namespace SFDC;

public partial class ClockOn4 : ContentPage
{
	public ClockOn4()
	{
		InitializeComponent();
	}

    async void GoToClockOn5(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ClockOn5));
    }

    async void BackToMain(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ClockOn3));
    }
}