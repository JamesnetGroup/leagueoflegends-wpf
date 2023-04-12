using System.Windows;
using System.Windows.Controls;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls
{
    public class LucasComboBoxItem : ComboBoxItem
    {
        #region DefaultStyleKey

        static LucasComboBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LucasComboBoxItem), new FrameworkPropertyMetadata(typeof(LucasComboBoxItem)));
        }
        #endregion
    }
}
