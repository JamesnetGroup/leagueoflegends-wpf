using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;

namespace Lol.Settings.UI.Views
{
    public class SettingView : View
    {
        #region Constructor

        static SettingView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SettingView), new FrameworkPropertyMetadata(typeof(SettingView)));
        }
        #endregion
    }
}
