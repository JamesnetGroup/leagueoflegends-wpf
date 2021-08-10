using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Home.UI.Views
{
	public class Overview : View
    {
        #region DefaultStyleKey

        static Overview()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Overview), new FrameworkPropertyMetadata(typeof(Overview)));
        }
		#endregion
	}
}
