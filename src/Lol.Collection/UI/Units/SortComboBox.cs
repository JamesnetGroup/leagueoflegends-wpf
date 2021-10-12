using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lol.Collection.UI.Units
{
    public class SortComboBox : ComboBox
    {
        #region DefalutStyleKey

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
