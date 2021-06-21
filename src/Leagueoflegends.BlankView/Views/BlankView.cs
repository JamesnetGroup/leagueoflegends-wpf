using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.BlankView.Views
{
	public class BlankView : View
    {
        static BlankView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BlankView), new FrameworkPropertyMetadata(typeof(BlankView)));
        }
    }
}
