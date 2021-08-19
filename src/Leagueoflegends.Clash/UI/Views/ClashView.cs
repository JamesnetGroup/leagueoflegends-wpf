using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Clash.UI.Views
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
