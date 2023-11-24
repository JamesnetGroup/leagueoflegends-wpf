using System.Windows;
using System.Windows.Controls;

namespace Lol.Collection.UI.Units
{
    public class SkinsLeftMenu : Control
    {
        #region DefaultStyleKey

        static SkinsLeftMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SkinsLeftMenu), new FrameworkPropertyMetadata(typeof(SkinsLeftMenu)));
        }
        #endregion
    }
}
