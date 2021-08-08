using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Settings.InGame.UI.Views
{
    public class HotKeyView : View
    {
        #region DefaultStyleKey

        static HotKeyView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HotKeyView), new FrameworkPropertyMetadata(typeof(HotKeyView)));
        }
        #endregion
    }
}
