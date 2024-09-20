using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Units
{
    public class NewSkin : Control
    {
        #region DefaultStyleKey

        static NewSkin()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NewSkin), new FrameworkPropertyMetadata(typeof(NewSkin)));
        }
        #endregion
    }
}
