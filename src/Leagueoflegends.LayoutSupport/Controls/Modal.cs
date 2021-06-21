using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.LayoutSupport.Controls
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