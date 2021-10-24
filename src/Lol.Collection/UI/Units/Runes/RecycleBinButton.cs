using System.Windows;
using System.Windows.Controls.Primitives;

namespace Lol.Collection.UI.Units
{
    public class RecycleBinButton : ToggleButton
    {
        #region DefaultStyleKey

        static RecycleBinButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RecycleBinButton), new FrameworkPropertyMetadata(typeof(RecycleBinButton)));
        }
        #endregion
    }
}
