using System.Windows;
using System.Windows.Controls;

namespace Lol.Collection.UI.Units
{
    public class SpellInfo : Control
    {
        #region DefaultStyleKey

        static SpellInfo()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SpellInfo), new FrameworkPropertyMetadata(typeof(SpellInfo)));
        }
        #endregion
    }
}
