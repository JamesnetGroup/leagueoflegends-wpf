using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;

namespace Lol.Settings.InGame.UI.Views
{
    public class InterfaceView : View
    {
        #region DefaultStyleKey

        static InterfaceView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InterfaceView), new FrameworkPropertyMetadata(typeof(InterfaceView)));
        }
        #endregion
    }
}
