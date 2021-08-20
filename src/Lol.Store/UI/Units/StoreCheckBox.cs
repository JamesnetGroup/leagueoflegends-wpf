using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Units
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
