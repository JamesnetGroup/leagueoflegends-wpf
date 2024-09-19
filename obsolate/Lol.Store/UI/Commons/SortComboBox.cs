using System.Windows;
using System.Windows.Controls;

namespace Lol.Store.UI.Commons
{
    public class SortComboBox : ComboBox
    {
        #region DefaultStyleKey

        static SortComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SortComboBox), new FrameworkPropertyMetadata(typeof(SortComboBox)));
        }
        #endregion

        #region DependencyProperty

        public static readonly DependencyProperty ContentProperty = DependencyProperty.Register("Content", typeof(object), typeof(SortComboBox), new PropertyMetadata(null));
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
            return new SortComboBoxItem();
        }
        #endregion
    }
}
