using System.Windows;
using System.Windows.Controls;

namespace Lol.Profile.UI.Units
{
    public class PlayChampListBox : ListBox
    {
        static PlayChampListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PlayChampListBox), new FrameworkPropertyMetadata(typeof(PlayChampListBox)));
        }
    }
}
