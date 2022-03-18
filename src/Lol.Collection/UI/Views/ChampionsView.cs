using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;

namespace Lol.Collection.UI.Views
{
    public class ChampionsView : View
    {
        #region DefaultStyleKey

        static ChampionsView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChampionsView), new FrameworkPropertyMetadata(typeof(ChampionsView)));
        }
        #endregion
    }
}
