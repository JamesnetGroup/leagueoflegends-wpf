using System.Windows;
using System.Windows.Controls.Primitives;

namespace Lol.Main.UI.Units
{
    public class FriendsExpander : ToggleButton
    {
        #region DefaultStyleKey

        static FriendsExpander()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FriendsExpander), new FrameworkPropertyMetadata(typeof(FriendsExpander)));
        }
        #endregion
    }
}
