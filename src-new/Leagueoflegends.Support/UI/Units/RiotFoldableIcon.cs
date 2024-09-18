
using System.Windows.Controls.Primitives;

namespace Leagueoflegends.Support.UI.Units;
class RiotFoldableIcon : ToggleButton
{
    public RiotFoldableIcon()
    {
        DefaultStyleKey = typeof(RiotFoldableIcon);
        
        // todolist: Tapped/DoubleTapped

        //Tapped += RiotFoldableIcon_Tapped;
        //DoubleTapped += RiotFoldableIcon_DoubleTapped;
    }

    //private void RiotFoldableIcon_Tapped(object sender, Microsoft.UI.Xaml.Input.TappedRoutedEventArgs e)
    //{
    //    e.Handled = true;
    //}

    //private void RiotFoldableIcon_DoubleTapped(object sender, Microsoft.UI.Xaml.Input.DoubleTappedRoutedEventArgs e)
    //{
    //    e.Handled = true;
    //}
}
