namespace SFDC;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	async void GoToClockIn(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(ClockIn));
	}

	async void GoToClockOut(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(ClockOut));
    }

	async void GoToClockInClockOut(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(ClockInClockOut));
	}
    async void GoToClockOn(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ClockOn));
    }

    async void GoToClockOff(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ClockOff));
    }
    async void GoToSupervisor(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Supervisor));
    }


}

