using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Units
{
    public class SkinLeftMenu : Control
    {
        #region DefaultStyleKey

        static SkinLeftMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SkinLeftMenu), new FrameworkPropertyMetadata(typeof(SkinLeftMenu)));
        }
        #endregion
    }
}
