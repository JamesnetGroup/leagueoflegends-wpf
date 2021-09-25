using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.GameRoom.UI.Views
{
    public class PVPView : View
    {
        static PVPView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PVPView), new FrameworkPropertyMetadata(typeof(PVPView)));
        }
    }
}
