using Leagueoflegends.Controls.Primitives;
using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.LayoutSupport.Controls
{
	public class ContentsWindow : MainWindow
	{
		#region DependencyProperties

		public static readonly DependencyProperty TopMenuTemplateProperty = DependencyProperty.Register("TopMenuTemplate", typeof(DataTemplate), typeof(ContentsWindow), new PropertyMetadata(null));
		public static readonly DependencyProperty ProfileTemplateProperty = DependencyProperty.Register("ProfileTemplate", typeof(DataTemplate), typeof(ContentsWindow), new PropertyMetadata(null));
		public static readonly DependencyProperty FriendsTemplateProperty = DependencyProperty.Register("FriendsTemplate", typeof(DataTemplate), typeof(ContentsWindow), new PropertyMetadata(null));
		public static readonly DependencyProperty ModalTemplateProperty = DependencyProperty.Register("ModalTemplate", typeof(DataTemplate), typeof(ContentsWindow), new PropertyMetadata(null));
		#endregion

		#region DefaultStyleKey

		static ContentsWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ContentsWindow), new FrameworkPropertyMetadata(typeof(ContentsWindow)));
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

		#region FriendsTemplate

		public DataTemplate ModalTemplate
		{
			get => (DataTemplate)GetValue(ModalTemplateProperty);
			set => SetValue(ModalTemplateProperty, value);
		}
		#endregion
	}
}
