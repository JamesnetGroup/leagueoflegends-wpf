using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.Clash.UI.Views
{
    public class HubView : View
    {
        #region DefaultStyleKey

        static HubView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HubView), new FrameworkPropertyMetadata(typeof(HubView)));
        }
        #endregion
    }
}
