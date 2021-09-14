using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.InGame.UI.Units
{
    public class Location : Control
    {
        #region DefaultStyleKey

        static Location()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Location), new FrameworkPropertyMetadata(typeof(Location)));
        }
        #endregion
    }
}
