using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Friends.UI.Units
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
