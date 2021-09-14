using System.Windows;
using System.Windows.Controls;

namespace Lol.TeamFight.UI.Units
{
    public class ItemInfo : Control
    {
        static ItemInfo()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemInfo), new FrameworkPropertyMetadata(typeof(ItemInfo)));
        }
    }
}
