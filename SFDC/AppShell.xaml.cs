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
        Routing.RegisterRoute(nameof(ClockOn2), typeof(ClockOn2));
        Routing.RegisterRoute(nameof(ClockOn3), typeof(ClockOn3));
        Routing.RegisterRoute(nameof(ClockOn4), typeof(ClockOn4));
        Routing.RegisterRoute(nameof(ClockOn5), typeof(ClockOn5));
        Routing.RegisterRoute(nameof(ClockOn6), typeof(ClockOn6));
        
        Routing.RegisterRoute(nameof(ClockOff), typeof(ClockOff));
    }
}
