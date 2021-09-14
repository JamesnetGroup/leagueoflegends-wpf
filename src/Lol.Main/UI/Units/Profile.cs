using System.Windows;
using System.Windows.Controls;

namespace Lol.Main.UI.Units
{
    public class Profile : ContentControl
    {
        #region DefaultStyleKey

        static Profile()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Profile), new FrameworkPropertyMetadata(typeof(Profile)));
        }
        #endregion
    }
}
