using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls
{
    public class CircleFace : Control
    {
        #region DefaultStyleKey

        static CircleFace()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CircleFace), new FrameworkPropertyMetadata(typeof(CircleFace)));
        }
        #endregion

        #region DependencyProperty

        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register("Source", typeof(ImageSource), typeof(CircleFace), new PropertyMetadata(null));
        #endregion

        #region Source

        public ImageSource Source
        {
            get { return (ImageSource)this.GetValue(SourceProperty); }
            set { this.SetValue(SourceProperty, value); }
        }
        #endregion
    }
}
