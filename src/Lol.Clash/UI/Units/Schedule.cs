using System.Windows;
using System.Windows.Controls;

namespace Lol.Clash.UI.Units
{
    public class Schedule : Control
    {
        #region DefaultStyleKey

        static Schedule()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Schedule), new FrameworkPropertyMetadata(typeof(Schedule)));
        }
        #endregion
    }
}
