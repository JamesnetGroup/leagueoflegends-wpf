using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Main.UI.Units
{
    public class MainMenu : Control
    {
        #region DefaultStyleKey

        static MainMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainMenu), new FrameworkPropertyMetadata(typeof(MainMenu)));
        }
        #endregion
    }
}