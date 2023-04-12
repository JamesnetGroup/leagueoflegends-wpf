using System.Windows;
using System.Windows.Controls;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls
{
    public class RiotButton : Button
    {
        #region DefaultStyleKey

        static RiotButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotButton), new FrameworkPropertyMetadata(typeof(RiotButton)));
        }
        #endregion

        #region DependencyProperty

        public static readonly DependencyProperty ContentMarginProperty = DependencyProperty.Register(
            "ContentMargin", typeof(Thickness), typeof(RiotButton), new PropertyMetadata(default(Thickness)));
        #endregion

        #region ContentMargin

        public Thickness ContentMargin
        {
            get { return (Thickness)GetValue(ContentMarginProperty); }
            set { SetValue(ContentMarginProperty, value); }
        }
        #endregion
    }
}
