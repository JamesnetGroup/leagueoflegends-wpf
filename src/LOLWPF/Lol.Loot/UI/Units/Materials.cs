using System.Windows;
using System.Windows.Controls;

namespace Lol.Loot.UI.Units
{
    public class Materials : TreeView
    {
        #region DefaultStyleKey

        static Materials()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Materials), new FrameworkPropertyMetadata(typeof(Materials)));
        }
        #endregion
    }
}
