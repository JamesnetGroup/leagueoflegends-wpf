using System.Windows;
using System.Windows.Controls;

namespace Lol.Home.UI.Units
{
    public class AvatarTitle : Control
    {
        #region DefaultStyleKey

        static AvatarTitle()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AvatarTitle), new FrameworkPropertyMetadata(typeof(AvatarTitle)));
        }
        #endregion
    }
}
