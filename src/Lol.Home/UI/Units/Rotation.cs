using System.Windows;
using System.Windows.Controls;

namespace Lol.Home.UI.Units
{
    public class Rotation : Control
    {
        #region DefaultStyleKey

        static Rotation()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Rotation), new FrameworkPropertyMetadata(typeof(Rotation)));
        }
        #endregion
    }
}
