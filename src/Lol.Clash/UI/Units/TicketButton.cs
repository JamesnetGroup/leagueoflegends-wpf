using System.Windows;
using System.Windows.Controls;

namespace Lol.Clash.UI.Units
{
    public class TicketButton : Button
    {
        #region DefaultStyleKey

        static TicketButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TicketButton), new FrameworkPropertyMetadata(typeof(TicketButton)));
        }
        #endregion
    }
}
