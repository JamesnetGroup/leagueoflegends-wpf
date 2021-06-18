using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.LayoutSupport.Controls
{
	public class DarkBackground : ContentControl
    {
        #region DefaultStyleKey

        static DarkBackground()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DarkBackground), new FrameworkPropertyMetadata(typeof(DarkBackground)));
        }
        #endregion
    }
}
