using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
	public class InterfaceSize : Control
    {
        static InterfaceSize()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InterfaceSize), new FrameworkPropertyMetadata(typeof(InterfaceSize)));
        }
    }
}
