using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Settings.UI.Views
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
