namespace SFDC;

public partial class ClockOn : ContentPage
{
	public ClockOn()
	{
		InitializeComponent();
	}

    async void GoToClockOn2(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ClockOn2));
    }

    async void BackToMain(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

}