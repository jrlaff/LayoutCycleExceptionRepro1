namespace LayoutCycleExceptionRepro1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Pressed(object sender, EventArgs e)
    {
        ScreensContainer.Children.Clear();

        ScreensContainer.Children.Add(new ProfileScreensControl(int.Parse(ScreensCount.Text), ScreensVisible.IsChecked));
    }
}
