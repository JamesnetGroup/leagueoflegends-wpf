using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.TitleBar.Views
{
    public class TitleBar : Control
    {
        static TitleBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TitleBar), new FrameworkPropertyMetadata(typeof(TitleBar)));
        }

        public TitleBar()
        {

        }
    }
}
