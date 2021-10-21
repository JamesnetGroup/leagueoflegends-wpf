using System.Windows;
using System.Windows.Controls;

namespace Lol.Loot.UI.Units
{
    public class CommonListItem : Button
    {
        #region DefaultStyleKey

        static CommonListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CommonListItem), new FrameworkPropertyMetadata(typeof(CommonListItem)));
        }
        #endregion
    }
}
