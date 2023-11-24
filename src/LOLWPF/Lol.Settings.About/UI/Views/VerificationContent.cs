using System.Windows;
using Jamesnet.Wpf.Controls;

namespace Lol.Settings.About.UI.Views
{
    public class VerificationContent : JamesContent
    {
        static VerificationContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(VerificationContent), new FrameworkPropertyMetadata(typeof(VerificationContent)));
        }
    }
}
