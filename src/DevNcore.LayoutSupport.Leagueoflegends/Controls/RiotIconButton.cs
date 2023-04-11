using DevNcore.LayoutSupport.Leagueoflegends.Utils;
using System.Windows;
using System.Windows.Controls;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls
{
    public class RiotIconButton : Button
    {
        #region DependencyProperty

        public static readonly DependencyProperty IconTypeProperty = DependencyProperty.Register("IconType", typeof(GeoIcon), typeof(RiotIconButton), new PropertyMetadata(GeoIcon.None));
        public static readonly DependencyProperty IconWidthProperty = DependencyProperty.Register("IconWidth", typeof(double), typeof(RiotIconButton), new PropertyMetadata(20.0));
        public static readonly DependencyProperty IconHeightProperty = DependencyProperty.Register("IconHeight", typeof(double), typeof(RiotIconButton), new PropertyMetadata(20.0));
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

        #region IconWidth

        public double IconWidth
        {
            get => (double)GetValue(IconWidthProperty);
            set => SetValue(IconWidthProperty, value);
        }
        #endregion

        #region IconHeight

        public double IconHeight
        {
            get => (double)GetValue(IconHeightProperty);
            set => SetValue(IconHeightProperty, value);
        }
        #endregion
    }
}
