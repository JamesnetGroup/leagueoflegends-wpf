using System.Windows;
using System.Windows.Controls;

namespace Lol.TeamFight.UI.Units
{
    public class ThumbnailButton : Button
    {
        #region DependencyProperty

        public static readonly DependencyProperty OrderProperty = DependencyProperty.Register("Order", typeof(int), typeof(ThumbnailButton), new PropertyMetadata(0));
        #endregion

        #region DefaultStyleKey

        static ThumbnailButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ThumbnailButton), new FrameworkPropertyMetadata(typeof(ThumbnailButton)));
        }
        #endregion

        #region OrderProperty

        public int Order
        {
            get { return (int)this.GetValue(OrderProperty); }
            set { this.SetValue(OrderProperty, value); }
        }
        #endregion
    }
}
