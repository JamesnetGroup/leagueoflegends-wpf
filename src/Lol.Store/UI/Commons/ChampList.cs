using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Units
{
    public class ChampList : ListBox
    {
        #region DefaultStyleKey

        static ChampList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChampList), new FrameworkPropertyMetadata(typeof(ChampList)));
        }
        #endregion
    }
}
