using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotChampSkinGroupItem : TreeViewItem
{
    public RiotChampSkinGroupItem()
    {
        DefaultStyleKey = typeof(RiotChampSkinGroupItem);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotChampSkinItemControl();
    }
}
