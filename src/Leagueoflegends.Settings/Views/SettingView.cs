using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Settings.Views
{
	public class SettingView : View
    {
        static SettingView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SettingView), new FrameworkPropertyMetadata(typeof(SettingView)));
        }
    }
}
