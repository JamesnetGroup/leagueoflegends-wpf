using Lol.Data.Enums;
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

namespace Lol.LayoutSupport.Controls
{
    public class RiotIconButton : Button
    {
        #region DependencyProperty

        public static readonly DependencyProperty IconTypeProperty = DependencyProperty.Register("IconType", typeof(GeoIcon), typeof(RiotIconButton), new PropertyMetadata(GeoIcon.None));
        #endregion

        #region DefaultStyleKey

        static RiotIconButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotIconButton), new FrameworkPropertyMetadata(typeof(RiotIconButton)));
        }
        #endregion

        #region IconType

        public GeoIcon IconType
        {
            get => (GeoIcon)GetValue(IconTypeProperty);
            set => SetValue(IconTypeProperty, value);
        }
        #endregion
    }
}
