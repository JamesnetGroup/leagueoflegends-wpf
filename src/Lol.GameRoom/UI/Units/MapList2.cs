using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class MapList2 : ListBox
    {
        #region DefaultStyleKey

        static MapList2()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MapList2), new FrameworkPropertyMetadata(typeof(MapList2)));
        }
        #endregion
    }
}
