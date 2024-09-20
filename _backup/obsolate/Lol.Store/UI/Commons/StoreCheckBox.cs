using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Commons
{
    public class StoreCheckBox : CheckBox
    {
        #region DefaultStyleKey

        static StoreCheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StoreCheckBox), new FrameworkPropertyMetadata(typeof(StoreCheckBox)));
        }
        #endregion
    }
}
