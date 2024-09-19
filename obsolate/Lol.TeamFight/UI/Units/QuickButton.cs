using System.Windows;
using System.Windows.Controls;

namespace Lol.TeamFight.UI.Units
{
    public class QuickButton : Control
    {
        #region DefaultStyleKey

        static QuickButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(QuickButton), new FrameworkPropertyMetadata(typeof(QuickButton)));
        }
        #endregion
    }
}
