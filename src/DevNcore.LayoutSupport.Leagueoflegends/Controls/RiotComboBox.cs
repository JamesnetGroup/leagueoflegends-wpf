using System.Windows;
using System.Windows.Controls;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls
{
    public class RiotComboBox : ComboBox
    {
        #region DefaultStyleKey

        static RiotComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotComboBox), new FrameworkPropertyMetadata(typeof(RiotComboBox)));
        }
        #endregion

        #region DependencyProperty

        public static readonly DependencyProperty ContentProperty = DependencyProperty.Register("Content", typeof(object), typeof(RiotComboBox), new PropertyMetadata(null));
        #endregion

        #region Content

        public object Content
        {
            get { return (object)this.GetValue(ContentProperty); }
            set { this.SetValue(ContentProperty, value); }
        }
        #endregion

        #region GetContainerForItemOverride

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new RiotComboBoxItem();
        }
        #endregion
    }
}
