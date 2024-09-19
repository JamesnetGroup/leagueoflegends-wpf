using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Leagueoflegends.Support.UI.Units;

public class RiotTabMenu : ListBox
{
    public static readonly DependencyProperty SelectionCommandProperty = DependencyProperty.Register("SelectionCommand", typeof(ICommand), typeof(RiotTabMenu), new PropertyMetadata(null));

    public ICommand SelectionCommand
    {
        get { return (ICommand)GetValue(SelectionCommandProperty); }
        set { SetValue(SelectionCommandProperty, value); }
    }

    public RiotTabMenu()
    {
        DefaultStyleKey = typeof(RiotTabMenu);
        SelectionChanged += RiotTabMenu_SelectionChanged;
    }

    private void RiotTabMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
                SelectionCommand?.Execute(listBoxItem.DataContext);
            }
        }
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotTabMenuItem();
    }
}
