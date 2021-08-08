using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Home.General.UI.Views
{
    public class OverView : View
    {
        static OverView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(OverView), new FrameworkPropertyMetadata(typeof(OverView)));
        }
    }
}
