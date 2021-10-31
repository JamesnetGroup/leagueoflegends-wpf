using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class MapTitle_Custom : Control
    {
        #region DefaultStyleKey


        static MapTitle_Custom()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MapTitle_Custom), new FrameworkPropertyMetadata(typeof(MapTitle_Custom)));
        }
        #endregion
    }
}
