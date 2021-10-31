using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class MapList_Custom : ListBox
    {
        #region DefaultStyleKey

        static MapList_Custom()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MapList_Custom), new FrameworkPropertyMetadata(typeof(MapList_Custom)));
        }
        #endregion
    }
}
