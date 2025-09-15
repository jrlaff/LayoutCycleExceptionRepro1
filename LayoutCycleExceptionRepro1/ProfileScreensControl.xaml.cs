namespace LayoutCycleExceptionRepro1;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class ProfileScreensControl : Grid
{
    public ProfileScreensControl(int screensCount, bool allVisible)
    {
        InitializeComponent();

        for (int i = 0; i < screensCount; i++)
            Children.Add(new AppletScreen { IsVisible = allVisible || i == 0 });
    }
}