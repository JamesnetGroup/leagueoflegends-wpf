using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Home.General.UI.Views
{
	public class GeneralView : View
    {
        static GeneralView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GeneralView), new FrameworkPropertyMetadata(typeof(GeneralView)));
        }
    }
}
