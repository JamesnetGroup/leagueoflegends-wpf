using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Settings.InGame.UI.Views
{
	public class InterfaceView : View
    {
        static InterfaceView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InterfaceView), new FrameworkPropertyMetadata(typeof(InterfaceView)));
        }
    }
}
