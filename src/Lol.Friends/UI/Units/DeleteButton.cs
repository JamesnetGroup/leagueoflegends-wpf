using System.Windows;
using System.Windows.Controls;

namespace Lol.Friends.UI.Units
{
    public class DeleteButton : Button
    {
        #region DefaultStyleKey

        static DeleteButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DeleteButton), new FrameworkPropertyMetadata(typeof(DeleteButton)));
        }
        #endregion
    }
}
