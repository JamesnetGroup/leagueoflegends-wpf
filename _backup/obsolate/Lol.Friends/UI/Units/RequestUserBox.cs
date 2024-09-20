using System.Windows;
using System.Windows.Controls;

namespace Lol.Friends.UI.Units
{
    public class RequestUserBox : ListBox
    {
        #region DefaultStyleKey

        static RequestUserBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RequestUserBox), new FrameworkPropertyMetadata(typeof(RequestUserBox)));
        }
        #endregion
    }
}
