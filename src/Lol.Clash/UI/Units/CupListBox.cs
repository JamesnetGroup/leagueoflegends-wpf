using System.Windows;
using System.Windows.Controls;

namespace Lol.Clash.UI.Units
{
    public class CupListBox : ListBox
    {
        #region DefaultStyleKey

        static CupListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CupListBox), new FrameworkPropertyMetadata(typeof(CupListBox)));
        }
        #endregion
    }
}
