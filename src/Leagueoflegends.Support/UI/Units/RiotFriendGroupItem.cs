using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotFriendGroupItem : TreeViewItem
{
    public RiotFriendGroupItem()
    {
        DefaultStyleKey = typeof(RiotFriendGroupItem);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotFriendItemControl();
    }
}
