using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class OkButton : Button
    {
        #region DefaultStyleKey

        static OkButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(OkButton), new FrameworkPropertyMetadata(typeof(OkButton)));
        }
        #endregion
    }
}
