using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Jamesnet.Wpf.Controls;

namespace Lol.Main.UI.Views
{
    public class MainContent : JamesContent
    {
        public Image BackgroundImage;

        static MainContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainContent), new FrameworkPropertyMetadata(typeof(MainContent)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            if (GetTemplateChild("PART_BackgroundImage") is Image img)
            {
                BackgroundImage = img;
            }

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
