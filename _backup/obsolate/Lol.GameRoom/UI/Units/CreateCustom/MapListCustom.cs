using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class MapListCustom : ListBox
    {
        #region DefaultStyleKey

        static MapListCustom()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MapListCustom), new FrameworkPropertyMetadata(typeof(MapListCustom)));
        }
        #endregion
    }
}
