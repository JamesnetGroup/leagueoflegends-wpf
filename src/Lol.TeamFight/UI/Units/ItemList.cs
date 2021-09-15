using System.Windows;
using System.Windows.Controls;

namespace Lol.TeamFight.UI.Units
{
    public class ItemList : ListBox
    {
        #region DefaultStyleKey

        static ItemList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemList), new FrameworkPropertyMetadata(typeof(ItemList)));
        }
        #endregion
    }
}
