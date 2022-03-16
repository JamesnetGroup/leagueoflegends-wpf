using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.Home.UI.Views
{
    public class AvatarView : View
    {
        #region DefaultStyleKey

        static AvatarView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AvatarView), new FrameworkPropertyMetadata(typeof(AvatarView)));
        }
        #endregion
    }
}
