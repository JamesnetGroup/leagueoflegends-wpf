using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.MyShop.UI.Units
{
    public class Title : Control
    {
        static Title()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Title), new FrameworkPropertyMetadata(typeof(Title)));
        }
    }
}
