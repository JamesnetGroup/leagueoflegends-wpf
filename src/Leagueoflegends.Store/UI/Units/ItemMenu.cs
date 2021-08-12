using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Store.UI.Units
{
	public class ItemMenu : Control
    {
        #region DefaultStyleKey

        static ItemMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemMenu), new FrameworkPropertyMetadata(typeof(ItemMenu)));
        }
        #endregion
    }
}
