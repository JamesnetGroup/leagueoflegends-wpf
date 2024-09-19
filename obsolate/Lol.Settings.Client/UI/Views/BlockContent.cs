using System.Windows;
using Jamesnet.Wpf.Controls;

namespace Lol.Settings.Client.UI.Views
{
    public class BlockContent : JamesContent
    {
        static BlockContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BlockContent), new FrameworkPropertyMetadata(typeof(BlockContent)));
        }
    }
}
