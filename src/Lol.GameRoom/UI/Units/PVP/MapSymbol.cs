using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class MapSymbol : Control
    {
        #region DefaultStyleKey

        static MapSymbol()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MapSymbol), new FrameworkPropertyMetadata(typeof(MapSymbol)));
        }
        #endregion
    }
}
