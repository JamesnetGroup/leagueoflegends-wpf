using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Home.General.Views
{
	public class GeneralView : View
    {
        static GeneralView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GeneralView), new FrameworkPropertyMetadata(typeof(GeneralView)));
        }
    }
}
