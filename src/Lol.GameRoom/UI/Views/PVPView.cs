using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.GameRoom.UI.Views
{
    public class PVPView : JamesContent
    {
        static PVPView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PVPView), new FrameworkPropertyMetadata(typeof(PVPView)));
        }

        public PVPView()
        { 
        
        }
    }
}
