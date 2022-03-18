using System.Windows;
using DevNcore.LayoutSupport.Leagueoflegends.Controls;

namespace Lol.Main.UI.Views
{
    public class MainView : MainWindow
    {
        #region DefaultStyleKey

        static MainView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainView), new FrameworkPropertyMetadata(typeof(MainView)));
        }
        #endregion
    }
}
