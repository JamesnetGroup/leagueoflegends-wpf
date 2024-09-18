
using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotMatchHistoryListBox : ListBox
{
    public RiotMatchHistoryListBox()
    {
        DefaultStyleKey = typeof(RiotMatchHistoryListBox);
        SelectionChanged += RiotMatchHistoryListBox_SelectionChanged;
    }

    private void RiotMatchHistoryListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
        return new RiotMatchHistoryListBoxItem();
    }
}
