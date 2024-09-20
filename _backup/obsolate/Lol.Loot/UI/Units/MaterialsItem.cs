using System.Windows;
using System.Windows.Controls;

namespace Lol.Loot.UI.Units
{
    public class MaterialsItem : Button
    {
        #region DefaultStyleKey

        static MaterialsItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MaterialsItem), new FrameworkPropertyMetadata(typeof(MaterialsItem)));
        }
        #endregion
    }
}
