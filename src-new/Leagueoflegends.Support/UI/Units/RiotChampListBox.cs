using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;
public class RiotChampListBox : ListBox
{
    public RiotChampListBox()
    {
        DefaultStyleKey = typeof(RiotChampListBox);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotChampGroupItem();
    }
}
