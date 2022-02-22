using System.Windows;
using System.Windows.Controls;

namespace Lol.Profile.UI.Units
{
    public class MyItemInfoListItem : ListBox
    {
        #region DefaultStyleKey

        static MyItemInfoListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyItemInfoListItem), new FrameworkPropertyMetadata(typeof(MyItemInfoListItem)));
        }
        #endregion
    }
}
