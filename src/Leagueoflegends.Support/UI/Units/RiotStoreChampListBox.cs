using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public sealed class RiotStoreChampListBox : ListBox
{
    public RiotStoreChampListBox()
    {
        DefaultStyleKey = typeof(RiotStoreChampListBox);
        SelectionChanged += RiotStoreChampListBox_SelectionChanged;
    }

    private void RiotStoreChampListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        foreach (var item in e.RemovedItems)
        {
            if (ItemContainerGenerator.ContainerFromItem(item) is ListBoxItem listBoxItem)
            {
                listBoxItem.IsSelected = false;
            }
        }

        foreach (var item in e.AddedItems)
        {
            if (ItemContainerGenerator.ContainerFromItem(item) is ListBoxItem listBoxItem)
            {
                listBoxItem.IsSelected = true;
            }
        }
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        var item = new RiotStoreChampListBoxItem();
        return item;
    }
}
