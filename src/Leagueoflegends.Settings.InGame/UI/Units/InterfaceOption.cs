using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
	public class InterfaceOption : Control
    {
        static InterfaceOption()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InterfaceOption), new FrameworkPropertyMetadata(typeof(InterfaceOption)));
        }
    }
}
