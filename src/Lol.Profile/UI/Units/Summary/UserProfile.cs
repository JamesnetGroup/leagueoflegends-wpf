using System.Windows;
using System.Windows.Controls;

namespace Lol.Profile.UI.Units
{
    public class UserProfile : Control
    {
        #region DefaultStyleKey

        static UserProfile()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(UserProfile), new FrameworkPropertyMetadata(typeof(UserProfile)));
        }
        #endregion
    }
}
