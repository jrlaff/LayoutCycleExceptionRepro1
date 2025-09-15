using Microsoft.Extensions.Logging;
using Microsoft.Maui.Layouts;

namespace LayoutCycleExceptionRepro1;

/// <summary>
/// A configurable applet screen in the user layout.
/// </summary>
/// <remarks>
/// Currently responsible for:
/// <list type="bullet">
/// <item>Defining the grid for applets</item>
/// <item>Instantiating configured (or default if none configured) applets and parenting them in the grid</item>
/// </list>
/// </remarks>
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class AppletScreen : Grid
{
    public AppletScreen()
    {
        InitializeComponent();

        Construct();
    }

    public void Construct()
    {
        for (int j = 0; j < 16; j++)
            ColumnDefinitions.Add(new ColumnDefinition());

        for (int i = 0; i < 10; i++)
            RowDefinitions.Add(new RowDefinition());

        AddAppletToGrid(new KeysListApplet(), left: 0, right: 2, top: 0, bottom: 2);
        AddAppletToGrid(new KeysListApplet(), left: 2, right: 4, top: 0, bottom: 2);
        AddAppletToGrid(new KeysListApplet(), left: 4, right: 6, top: 0, bottom: 2);
        AddAppletToGrid(new KeysListApplet(), left: 6, right: 8, top: 0, bottom: 2);
        AddAppletToGrid(new KeysListApplet(), left: 8, right: 10, top: 0, bottom: 2);
        AddAppletToGrid(new KeysListApplet(), left: 10, right: 12, top: 0, bottom: 2);
        AddAppletToGrid(new KeysListApplet(), left: 12, right: 14, top: 0, bottom: 2);
        AddAppletToGrid(new KeysListApplet(), left: 14, right: 16, top: 0, bottom: 2);

        AddAppletToGrid(new KeysListApplet(), left: 0, right: 2, top: 2, bottom: 4);
        AddAppletToGrid(new KeysListApplet(), left: 2, right: 4, top: 2, bottom: 4);
        AddAppletToGrid(new KeysListApplet(), left: 4, right: 6, top: 2, bottom: 4);
        AddAppletToGrid(new KeysListApplet(), left: 6, right: 8, top: 2, bottom: 4);
        AddAppletToGrid(new KeysListApplet(), left: 8, right: 10, top: 2, bottom: 4);
        AddAppletToGrid(new KeysListApplet(), left: 10, right: 12, top: 2, bottom: 4);
        AddAppletToGrid(new KeysListApplet(), left: 12, right: 14, top: 2, bottom: 4);
        AddAppletToGrid(new KeysListApplet(), left: 14, right: 16, top: 2, bottom: 4);

        AddAppletToGrid(new KeysListApplet(), left: 0, right: 2, top: 4, bottom: 6);
        AddAppletToGrid(new KeysListApplet(), left: 2, right: 4, top: 4, bottom: 6);
        AddAppletToGrid(new KeysListApplet(), left: 4, right: 6, top: 4, bottom: 6);
        AddAppletToGrid(new KeysListApplet(), left: 6, right: 8, top: 4, bottom: 6);
        AddAppletToGrid(new KeysListApplet(), left: 8, right: 10, top: 4, bottom: 6);
        AddAppletToGrid(new KeysListApplet(), left: 10, right: 12, top: 4, bottom: 6);
        AddAppletToGrid(new KeysListApplet(), left: 12, right: 14, top: 4, bottom: 6);
        AddAppletToGrid(new KeysListApplet(), left: 14, right: 16, top: 4, bottom: 6);

        AddAppletToGrid(new KeysListApplet(), left: 0, right: 2, top: 6, bottom: 8);
        AddAppletToGrid(new KeysListApplet(), left: 2, right: 4, top: 6, bottom: 8);
        AddAppletToGrid(new KeysListApplet(), left: 4, right: 6, top: 6, bottom: 8);
        AddAppletToGrid(new KeysListApplet(), left: 6, right: 8, top: 6, bottom: 8);
        AddAppletToGrid(new KeysListApplet(), left: 8, right: 10, top: 6, bottom: 8);
        AddAppletToGrid(new KeysListApplet(), left: 10, right: 12, top: 6, bottom: 8);
        AddAppletToGrid(new KeysListApplet(), left: 12, right: 14, top: 6, bottom: 8);
        AddAppletToGrid(new KeysListApplet(), left: 14, right: 16, top: 6, bottom: 8);

        AddAppletToGrid(new KeysListApplet(), left: 0, right: 2, top: 8, bottom: 10);
        AddAppletToGrid(new KeysListApplet(), left: 2, right: 4, top: 8, bottom: 10);
        AddAppletToGrid(new KeysListApplet(), left: 4, right: 6, top: 8, bottom: 10);
        AddAppletToGrid(new KeysListApplet(), left: 6, right: 8, top: 8, bottom: 10);
        AddAppletToGrid(new KeysListApplet(), left: 8, right: 10, top: 8, bottom: 10);
        AddAppletToGrid(new KeysListApplet(), left: 10, right: 12, top: 8, bottom: 10);
        AddAppletToGrid(new KeysListApplet(), left: 12, right: 14, top: 8, bottom: 10);
        AddAppletToGrid(new KeysListApplet(), left: 14, right: 16, top: 8, bottom: 10);
    }

    private void AddAppletToGrid(ContentView applet, int left, int right, int top, int bottom)
    {
        this.AddWithSpan(applet, top, left, bottom - top, right - left);
    }
}
