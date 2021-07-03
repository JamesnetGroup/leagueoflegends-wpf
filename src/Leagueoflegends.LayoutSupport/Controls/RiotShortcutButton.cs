using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.LayoutSupport.Controls
{
	public class RiotShortcutButton : Button
    {
        static RiotShortcutButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotShortcutButton), new FrameworkPropertyMetadata(typeof(RiotShortcutButton)));
        }
    }
}
