using System.Windows;
using Jamesnet.Wpf.Controls;

namespace Lol.Settings.Client.UI.Views
{
    public class GeneralContent : JamesContent
    {
        static GeneralContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GeneralContent), new FrameworkPropertyMetadata(typeof(GeneralContent)));
        }
    }
}
