using Leagueoflegends.LayoutSupport;
using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Main.Views
{
    public class MainView : MainWindow
    {
        static MainView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainView), new FrameworkPropertyMetadata(typeof(MainView)));
        }
    }
}
