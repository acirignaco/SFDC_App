namespace SFDC;

public partial class ClockOn3 : ContentPage
{
	public ClockOn3()
	{
		InitializeComponent();
	}

    async void GoToClockOn4(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ClockOn4));
    }

    async void BackToMain(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ClockOn2));
    }


}