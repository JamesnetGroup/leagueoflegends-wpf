using System.Windows;
using System.Windows.Controls;

namespace Lol.GameRoom.UI.Units
{
    public class ConfirmButton_Join : Button
    {
        #region DefaultStyleKey

        static ConfirmButton_Join()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ConfirmButton_Join), new FrameworkPropertyMetadata(typeof(ConfirmButton_Join)));
        }
        #endregion
    }
}
