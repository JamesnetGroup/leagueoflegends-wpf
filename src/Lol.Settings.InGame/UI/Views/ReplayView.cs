using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;

namespace Lol.Settings.InGame.UI.Views
{
    public class ReplayView : View
    {
        #region DefaultStyleKey

        static ReplayView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ReplayView), new FrameworkPropertyMetadata(typeof(ReplayView)));
        }
        #endregion
    }
}
