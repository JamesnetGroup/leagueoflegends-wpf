using System.Windows;
using System.Windows.Controls;

namespace Lol.TeamFight.UI.Units
{
    public class ItemInfo : Control
    {
        #region DefaultStyleKey

        static ItemInfo()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemInfo), new FrameworkPropertyMetadata(typeof(ItemInfo)));
        }
        #endregion
    }
}
