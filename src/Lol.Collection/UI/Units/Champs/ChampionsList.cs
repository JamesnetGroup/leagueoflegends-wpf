using System.Windows;
using System.Windows.Controls;

namespace Lol.Collection.UI.Units
{
    public class ChampionsList : TreeView
    {
        #region DefaultStyleKey

        static ChampionsList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChampionsList), new FrameworkPropertyMetadata(typeof(ChampionsList)));
        }
        #endregion
    }
}
