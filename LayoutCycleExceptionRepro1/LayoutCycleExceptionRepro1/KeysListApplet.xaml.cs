using System.Collections.ObjectModel;

namespace LayoutCycleExceptionRepro1;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class KeysListApplet : ContentView
{
    public ObservableCollection<string> KeyGroups
    {
        get
        {
            return [
                "Group 1",
                "Group 2",
                "Group 3",
                "Group 4",
                "Group 5",
                "Group 6",
            ];
        }
        set
        { }
    }

    public KeysListApplet()
    {
        InitializeComponent();
    }
}
