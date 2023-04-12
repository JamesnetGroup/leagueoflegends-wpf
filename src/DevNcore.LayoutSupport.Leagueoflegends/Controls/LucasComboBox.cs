using System.Windows;
using System.Windows.Controls;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls
{
    public class LucasComboBox : ComboBox
    {

        #region DefaultStyleKey

        static LucasComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LucasComboBox), new FrameworkPropertyMetadata(typeof(LucasComboBox)));
        }
        #endregion

        #region GetContainerForItemOverride

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new LucasComboBoxItem();
        }

        #endregion
    }
}
