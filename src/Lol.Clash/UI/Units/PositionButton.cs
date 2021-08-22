using Lol.Controls.Primitives;
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

namespace Lol.Clash.UI.Units
{

    public class PositionButton : Control
    {
        public static readonly DependencyProperty SendIconTypeProperty = DependencyProperty.Register("SendIconType", typeof(GeoIcon), typeof(PositionButton), new PropertyMetadata(GeoIcon.None));
        #region Constructor

        static PositionButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PositionButton), new FrameworkPropertyMetadata(typeof(PositionButton)));
        }
        #endregion

        //TODO: [Kevin] 이 방법이 최선인가 추후 수정???
        #region SendIconType

        public GeoIcon SendIconType
        {
            get => (GeoIcon)GetValue(SendIconTypeProperty);
            set => SetValue(SendIconTypeProperty, value);
        }
        #endregion
    }

}
