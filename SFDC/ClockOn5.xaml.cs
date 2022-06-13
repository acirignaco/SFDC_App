namespace SFDC;

public partial class ClockOn5 : ContentPage
{
	public ClockOn5()
	{
		InitializeComponent();
	}

    async void GoToClockOn6(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ClockOn6));
    }

    async void BackToMain(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ClockOn4));
    }


}