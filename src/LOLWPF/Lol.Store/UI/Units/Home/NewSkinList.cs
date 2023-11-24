using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Units
{
    public class NewSkinList : ListBox
    {
        #region DefaultStyleKey

        static NewSkinList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NewSkinList), new FrameworkPropertyMetadata(typeof(NewSkinList)));
        }
        #endregion
    }
}
