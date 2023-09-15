using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Settings.UI.Views
{
    public class SettingView : JamesContent
    {
        static SettingView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SettingView), new FrameworkPropertyMetadata(typeof(SettingView)));
        }
    }
}
