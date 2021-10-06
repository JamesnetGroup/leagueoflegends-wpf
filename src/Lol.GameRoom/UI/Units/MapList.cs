using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class MapList : ListBox
    {
        #region DefaultStyleKey

        static MapList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MapList), new FrameworkPropertyMetadata(typeof(MapList)));
        }
        #endregion
    }
}
