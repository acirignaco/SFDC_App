namespace SFDC;

public partial class ClockOn2 : ContentPage
{
	public ClockOn2()
	{
		InitializeComponent();
	}
    async void GoToClockOn3(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ClockOn3));
    }

    async void BackToMain(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ClockOn));
    }

}