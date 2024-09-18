using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Leagueoflegends.Support.UI.Units;

public class RiotTabMenu : ListBox
{
    private Grid _uniformGrid;
    private int _columns = 2;
    private int _currentColumn = 0;
    private int _currentRow = 0;

    public static readonly DependencyProperty SelectionCommandProperty = DependencyProperty.Register("SelectionCommand", typeof(ICommand), typeof(RiotTabMenu), new PropertyMetadata(null));

    public ICommand SelectionCommand
    {
        get { return (ICommand)GetValue(SelectionCommandProperty); }
        set { SetValue(SelectionCommandProperty, value); }
    }

    public int Columns
    {
        get => _columns;
        set { _columns = value; UpdateUniformGrid(); }
    }

    public RiotTabMenu()
    {
        DefaultStyleKey = typeof(RiotTabMenu);
        SelectionChanged += RiotTabMenu_SelectionChanged;
    }

    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        _uniformGrid = GetTemplateChild("PART_UniformGrid") as Grid;
        UpdateUniformGrid();
    }

    protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e)
    {
        base.OnItemsChanged(e);
        UpdateUniformGrid();
    }

    private void UpdateUniformGrid()
    {
        if (_uniformGrid == null) return;

        _uniformGrid.ColumnDefinitions.Clear();
        for (int i = 0; i < _columns; i++)
        {
            _uniformGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        }

        int itemCount = Items.Count;
        int rows = (itemCount + _columns - 1) / _columns;

        _uniformGrid.RowDefinitions.Clear();
        for (int i = 0; i < rows; i++)
        {
            _uniformGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
        }

        // Reset positioning counters
        _currentColumn = 0;
        _currentRow = 0;
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
        var item = new RiotTabMenuItem();
        Grid.SetRow(item, _currentRow);
        Grid.SetColumn(item, _currentColumn);

        _currentColumn++;
        if (_currentColumn >= _columns)
        {
            _currentColumn = 0;
            _currentRow++;
        }

        return item;
    }
}
