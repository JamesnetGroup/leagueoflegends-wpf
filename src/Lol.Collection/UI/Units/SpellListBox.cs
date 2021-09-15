using System.Windows;
using System.Windows.Controls;


namespace Lol.Collection.UI.Units
{
    public class SpellListBox : ListBox
    {
        static SpellListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SpellListBox), new FrameworkPropertyMetadata(typeof(SpellListBox)));
        }
    }
}
