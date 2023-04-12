using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls
{
    public class SkinTierButton : Button
    {
        #region DependencyProperty

        public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(SkinTierButton));
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(SkinTierButton));
        public static readonly DependencyProperty ToolTipValueProperty = DependencyProperty.Register("ToolTipValue", typeof(object), typeof(SkinTierButton));
        public static readonly DependencyProperty IsTierProperty = DependencyProperty.Register("IsTier", typeof(bool), typeof(SkinTierButton));
        #endregion

        #region DefaultStyleKey

        static SkinTierButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SkinTierButton), new FrameworkPropertyMetadata(typeof(SkinTierButton)));
        }
        #endregion

        #region ImageSource

        public ImageSource ImageSource
        {
            get => (ImageSource)GetValue(ImageSourceProperty);
            set => SetValue(ImageSourceProperty, value);
        }
        #endregion

        #region Text

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
        #endregion

        #region ToolTipValue

        public object ToolTipValue
        {
            get => GetValue(ToolTipValueProperty);
            set => SetValue(ToolTipValueProperty, value);
        }
        #endregion

        #region IsTier

        public bool IsTier
        {
            get => (bool)GetValue(IsTierProperty);
            set => SetValue(IsTierProperty, value);
        }
        #endregion
    }
}
