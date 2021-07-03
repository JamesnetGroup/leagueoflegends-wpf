using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.TeamFight.UI.Units
{
	public class UpgradeButton : Button
    {
        static UpgradeButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(UpgradeButton), new FrameworkPropertyMetadata(typeof(UpgradeButton)));
        }
    }
}
