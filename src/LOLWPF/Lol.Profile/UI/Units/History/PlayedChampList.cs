using System.Windows;
using System.Windows.Controls;

namespace Lol.Profile.UI.Units
{
    public class PlayedChampList : ListBox
    {
        #region DefaultStyleKey

        static PlayedChampList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PlayedChampList), new FrameworkPropertyMetadata(typeof(PlayedChampList)));
        }
        #endregion
    }
}
