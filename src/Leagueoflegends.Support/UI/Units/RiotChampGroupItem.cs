using Jamesnet.Platform.WPF;
using System.Windows;

namespace Leagueoflegends.Support.UI.Units;

public class RiotChampGroupItem : RecursiveControl
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
