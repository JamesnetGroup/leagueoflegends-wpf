using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.InGame.UI.Units
{
    public class Option : Control
    {
        #region DefaultStyleKey

        static Option()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Option), new FrameworkPropertyMetadata(typeof(Option)));
        }
        #endregion
    }
}
