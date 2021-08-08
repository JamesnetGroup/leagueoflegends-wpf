using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
    public class Items : Control
    {
        #region DefaultStyleKey

        static Items()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Items), new FrameworkPropertyMetadata(typeof(Items)));
        }
        #endregion
    }
}
