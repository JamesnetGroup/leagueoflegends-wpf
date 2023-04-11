using System.Windows;
using System.Windows.Controls;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls
{
    public class Modal : ContentControl
    {
        #region DefaultStyleKey

        static Modal()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Modal), new FrameworkPropertyMetadata(typeof(Modal)));
        }
        #endregion
    }
}