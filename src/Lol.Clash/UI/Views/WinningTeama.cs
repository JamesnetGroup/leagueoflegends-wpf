using Lol.LayoutSupport.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lol.Clash.UI.Views
{
    public class WinningTeama : View
    {
        static WinningTeama()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WinningTeama), new FrameworkPropertyMetadata(typeof(WinningTeama)));
        }
    }
}
