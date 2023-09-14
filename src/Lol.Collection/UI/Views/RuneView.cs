using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.Collection.UI.Views
{
    public class RuneView : JamesContent
    {
        #region DefaultStyleKey


        static RuneView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RuneView), new FrameworkPropertyMetadata(typeof(RuneView)));
        }
        #endregion
    }
}
