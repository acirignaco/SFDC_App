namespace SFDC;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(ClockIn), typeof(ClockIn));
        Routing.RegisterRoute(nameof(ClockOut), typeof(ClockOut));
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(ClockInClockOut), typeof(ClockInClockOut));
        Routing.RegisterRoute(nameof(Supervisor), typeof(Supervisor));
        Routing.RegisterRoute(nameof(ClockOn), typeof(ClockOn));
        Routing.RegisterRoute(nameof(ClockOff), typeof(ClockOff));
    }
}
