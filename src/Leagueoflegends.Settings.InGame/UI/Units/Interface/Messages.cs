using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
    public class Messages : Control
    {
        #region DefaultStyleKey

        static Messages()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Messages), new FrameworkPropertyMetadata(typeof(Messages)));
        }
        #endregion
    }
}
