using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Home.General.UI.Units
{
	public class Thumbnail : View
    {
        static Thumbnail()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Thumbnail), new FrameworkPropertyMetadata(typeof(Thumbnail)));
        }
    }
}
