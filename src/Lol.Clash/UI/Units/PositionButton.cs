using DevNcore.LayoutSupport.Leagueoflegends.Utils;
using System.Windows;
using System.Windows.Controls;

namespace Lol.Clash.UI.Units
{
    public class PositionButton : Button
    {
        #region DefaultStyleKey

        static PositionButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PositionButton), new FrameworkPropertyMetadata(typeof(PositionButton)));
        }
        #endregion

        #region DependencyProperty

        public static readonly DependencyProperty SendIconTypeProperty = DependencyProperty.Register("SendIconType", typeof(GeoIcon), typeof(PositionButton), new PropertyMetadata(GeoIcon.None));
        #endregion

        // TODO: [Kevin] 이 방법이 최선인가 추후 수정???
        // 설명: ??
        #region SendIconType

        public GeoIcon SendIconType
        {
            get => (GeoIcon)GetValue(SendIconTypeProperty);
            set => SetValue(SendIconTypeProperty, value);
        }
        #endregion
    }

}
