using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.Clash.UI.Views
{
	public class ClashView : View
    {
        #region DefaultStyleKey

        static ClashView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ClashView), new FrameworkPropertyMetadata(typeof(ClashView)));
        }
        #endregion
    }
}
