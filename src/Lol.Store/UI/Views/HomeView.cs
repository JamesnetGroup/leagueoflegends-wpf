using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;

namespace Lol.Store.UI.Views
{
    public class HomeView : View
    {
        #region DefaultStyleKey

        static HomeView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HomeView), new FrameworkPropertyMetadata(typeof(HomeView)));
        }
        #endregion
    }
}
