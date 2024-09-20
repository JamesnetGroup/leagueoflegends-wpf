using System.Windows;
using System.Windows.Controls;

namespace Lol.Settings.InGame.UI.Units
{
    public class Spells : Control
    {
        #region DefaultStyleKey

        static Spells()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Spells), new FrameworkPropertyMetadata(typeof(Spells)));
        }
        #endregion
    }
}
