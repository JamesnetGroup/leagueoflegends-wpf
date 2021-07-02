using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Game.Shortcut.UI.Units
{
	public class SkillKeyButton : Control
    {
        static SkillKeyButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SkillKeyButton), new FrameworkPropertyMetadata(typeof(SkillKeyButton)));
        }
    }
}
