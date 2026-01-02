using SCPSharp.Views;

namespace SCPSharp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        UserAppTheme = AppTheme.Light;
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new MainWindow();
    }
}