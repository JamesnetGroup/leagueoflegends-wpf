using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class MapTitleCustom : Control
    {
        #region DefaultStyleKey


        static MapTitleCustom()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MapTitleCustom), new FrameworkPropertyMetadata(typeof(MapTitleCustom)));
        }
        #endregion
    }
}
