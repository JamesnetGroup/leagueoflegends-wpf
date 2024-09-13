using System.Windows.Controls;

namespace Leagueoflegends.Support.UI.Units;
public class RiotHorizMenuListBoxItem : ListBoxItem
{
    private bool _isSelected;

    public RiotHorizMenuListBoxItem()
    {
        DefaultStyleKey = typeof(RiotHorizMenuListBoxItem);
    }
}
