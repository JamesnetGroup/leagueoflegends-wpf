using DevNcore.LayoutSupport.Leagueoflegends.Controls.Primitives;
using System.Windows;
using System.Windows.Controls;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls
{
    public class MainWindow : BaseWindow
    {
        #region DependencyProperties

        public static readonly DependencyProperty TopMenuTemplateProperty = DependencyProperty.Register("TopMenuTemplate", typeof(DataTemplate), typeof(MainWindow), new PropertyMetadata(null));
        public static readonly DependencyProperty ProfileTemplateProperty = DependencyProperty.Register("ProfileTemplate", typeof(DataTemplate), typeof(MainWindow), new PropertyMetadata(null));
        public static readonly DependencyProperty FriendsTemplateProperty = DependencyProperty.Register("FriendsTemplate", typeof(DataTemplate), typeof(MainWindow), new PropertyMetadata(null));
        public static readonly DependencyProperty ModalTemplateProperty = DependencyProperty.Register("ModalTemplate", typeof(DataTemplate), typeof(MainWindow), new PropertyMetadata(null));
        public static readonly DependencyProperty BackgroundTemplateProperty = DependencyProperty.Register("BackgroundTemplate", typeof(DataTemplate), typeof(MainWindow), new PropertyMetadata(null));
        #endregion

        #region DefaultStyleKey

        static MainWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainWindow), new FrameworkPropertyMetadata(typeof(MainWindow)));
        }
        #endregion

        #region Variables

        public Image BackgroundImage;
        #endregion

        #region OnApplyTemplate

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            if (GetTemplateChild("PART_BackgroundImage") is Image img)
            {
                BackgroundImage = img;
            }
        }
        #endregion

        #region TopMenuTemplate

        public DataTemplate TopMenuTemplate
        {
            get => (DataTemplate)GetValue(TopMenuTemplateProperty);
            set => SetValue(TopMenuTemplateProperty, value);
        }
        #endregion

        #region ProfileTemplate

        public DataTemplate ProfileTemplate
        {
            get => (DataTemplate)GetValue(ProfileTemplateProperty);
            set => SetValue(ProfileTemplateProperty, value);
        }
        #endregion

        #region FriendsTemplate

        public DataTemplate FriendsTemplate
        {
            get => (DataTemplate)GetValue(FriendsTemplateProperty);
            set => SetValue(FriendsTemplateProperty, value);
        }
        #endregion

        #region ModalTemplate

        public DataTemplate ModalTemplate
        {
            get => (DataTemplate)GetValue(ModalTemplateProperty);
            set => SetValue(ModalTemplateProperty, value);
        }
        #endregion

        #region BackgroundTemplate

        public DataTemplate BackgroundTemplate
        {
            get => (DataTemplate)GetValue(BackgroundTemplateProperty);
            set => SetValue(BackgroundTemplateProperty, value);
        }
        #endregion
    }
}
