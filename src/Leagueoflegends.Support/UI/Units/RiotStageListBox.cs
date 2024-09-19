using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotStageListBox : ListBox
{
    public RiotStageListBox()
    {
        DefaultStyleKey = typeof(RiotStageListBox);
        SelectionChanged += RiotStageListBox_SelectionChanged;
    }

    private void RiotStageListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
        return new RiotStageListBoxItem();
    }
}
