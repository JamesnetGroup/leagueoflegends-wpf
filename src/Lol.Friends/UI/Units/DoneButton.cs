using System.Windows;
using System.Windows.Controls;

namespace Lol.Friends.UI.Units
{
    public class DoneButton : Button
    {
        #region DefaultStyleKey

        static DoneButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DoneButton), new FrameworkPropertyMetadata(typeof(DoneButton)));
        }
        #endregion
    }
}
