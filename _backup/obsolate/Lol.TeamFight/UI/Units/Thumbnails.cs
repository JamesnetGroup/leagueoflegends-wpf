using System.Windows;
using System.Windows.Controls;

namespace Lol.TeamFight.UI.Units
{
    public class Thumbnails : Control
    {
        #region DefaultStyleKey

        static Thumbnails()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Thumbnails), new FrameworkPropertyMetadata(typeof(Thumbnails)));
        }
        #endregion
    }
}
