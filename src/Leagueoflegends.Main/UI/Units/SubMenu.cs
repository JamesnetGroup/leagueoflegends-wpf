using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Main.UI.Units
{
    public class SubMenu : ListBox
    {
        #region DefaultStyleKey

        static SubMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SubMenu), new FrameworkPropertyMetadata(typeof(SubMenu)));
        }
        #endregion
    }
}
