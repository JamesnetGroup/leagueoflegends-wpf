using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;
public class RiotPlayedChampListBox : ListBox
{
    public RiotPlayedChampListBox()
    {
        DefaultStyleKey = typeof(RiotPlayedChampListBox);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotPlayedChampListBoxItem();
    }
}
