using System.Windows;
using System.Windows.Controls;

namespace Lol.TeamFight.UI.Units
{
    public class UpgradeButton : Button
    {
        #region DefaultStyleKey

        static UpgradeButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(UpgradeButton), new FrameworkPropertyMetadata(typeof(UpgradeButton)));
        }
        #endregion
    }
}
