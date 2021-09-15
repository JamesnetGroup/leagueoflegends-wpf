using System.Windows;
using System.Windows.Controls;

namespace Lol.TeamFight.UI.Units
{
    public class SubTitleControl : Control
    {
        #region DefaultStyleKey

        static SubTitleControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SubTitleControl), new FrameworkPropertyMetadata(typeof(SubTitleControl)));
        }
        #endregion
    }
}
