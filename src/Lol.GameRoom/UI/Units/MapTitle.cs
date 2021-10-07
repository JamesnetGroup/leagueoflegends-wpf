using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class MapTitle : Control
    {
        #region DefaultStyleKey

        static MapTitle()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MapTitle), new FrameworkPropertyMetadata(typeof(MapTitle)));
        }
        #endregion
    }
}
