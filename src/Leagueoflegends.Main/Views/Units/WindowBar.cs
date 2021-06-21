using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Main.Views
{
    public class WindowBar : Control
    {
        static WindowBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowBar), new FrameworkPropertyMetadata(typeof(WindowBar)));
        }

        public WindowBar()
        {

        }
    }
}
