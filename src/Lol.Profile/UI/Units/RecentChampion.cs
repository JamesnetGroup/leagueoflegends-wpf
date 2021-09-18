using System.Windows;
using System.Windows.Controls;

namespace Lol.Profile.UI.Units
{
    public class RecentChampion : Control
    {
        static RecentChampion()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RecentChampion), new FrameworkPropertyMetadata(typeof(RecentChampion)));
        }
    }
}
