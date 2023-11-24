using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Lol.Menus.UI.Views
{
    public class MenuContent : JamesContent
    {
        static MenuContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MenuContent), new FrameworkPropertyMetadata(typeof(MenuContent)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            if (GetTemplateChild("PART_DragBar") is Border bar)
            {
                bar.MouseDown += Bar_MouseDown;
            }
        }

        private void Bar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Window.GetWindow(this).DragMove();
            }
        }
    }
}
