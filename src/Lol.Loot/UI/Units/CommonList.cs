using System.Windows;
using System.Windows.Controls;

namespace Lol.Loot.UI.Units
{
    public class CommonList : TreeView
    {
        #region DefaultStyleKey

        static CommonList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CommonList), new FrameworkPropertyMetadata(typeof(CommonList)));
        }
        #endregion
    }
}
