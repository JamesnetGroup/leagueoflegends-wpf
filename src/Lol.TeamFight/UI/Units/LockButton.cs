using System.Windows;
using System.Windows.Controls;

namespace Lol.TeamFight.UI.Units
{
    public class LockButton : Button
    {
        #region DefaultStyleKey

        static LockButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LockButton), new FrameworkPropertyMetadata(typeof(LockButton)));
        }
        #endregion
    }
}
