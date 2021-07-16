using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Settings.Client.UI.Views
{
	public class NormalView : View
    {
        #region DefaultStyleKey

        static NormalView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NormalView), new FrameworkPropertyMetadata(typeof(NormalView)));
        }
		#endregion
	}
}
