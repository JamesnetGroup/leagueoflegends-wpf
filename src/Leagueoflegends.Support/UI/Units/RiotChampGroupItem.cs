using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotChampGroupItem : TreeViewItem
{
    public RiotChampGroupItem()
    {
        DefaultStyleKey = typeof(RiotChampGroupItem);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotChampItemControl();
    }
}
