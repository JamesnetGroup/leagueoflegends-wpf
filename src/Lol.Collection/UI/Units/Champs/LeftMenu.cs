using System.Windows;
using System.Windows.Controls;

namespace Lol.Collection.UI.Units
{
    public class LeftMenu : Control
    {
        #region DefaultStyleKey

        static LeftMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LeftMenu), new FrameworkPropertyMetadata(typeof(LeftMenu)));
        }
        #endregion
    }
}
