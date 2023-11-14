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
        }
    }
}
