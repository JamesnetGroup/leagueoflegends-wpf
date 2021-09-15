using System.Windows;
using System.Windows.Controls;

namespace Lol.TeamFight.UI.Units
{
    public class FatesPass : Control
    {
        #region DefaultStyleKey

        static FatesPass()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FatesPass), new FrameworkPropertyMetadata(typeof(FatesPass)));
        }
        #endregion
    }
}
