using System.Windows;
using System.Windows.Controls;

namespace Lol.Collection.UI.Units
{
    public class SpellListBox : ListBox
    {
        #region DefaultStyleKey

        static SpellListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SpellListBox), new FrameworkPropertyMetadata(typeof(SpellListBox)));
        }
        #endregion
    }
}
