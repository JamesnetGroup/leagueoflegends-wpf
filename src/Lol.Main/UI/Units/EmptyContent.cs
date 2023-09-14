using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Main.UI.Units
{
    public class EmptyContent : JamesContent
    {
        #region DefaultStyleKey

        static EmptyContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(EmptyContent), new FrameworkPropertyMetadata(typeof(EmptyContent)));
        }
        #endregion
    }
}
