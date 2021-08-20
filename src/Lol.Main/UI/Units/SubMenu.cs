using System.Windows;
using System.Windows.Controls;

namespace Lol.Main.UI.Units
{
    public class SubMenu : ListBox
    {
        #region DefaultStyleKey

        static SubMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SubMenu), new FrameworkPropertyMetadata(typeof(SubMenu)));
        }
        #endregion
    }
}
