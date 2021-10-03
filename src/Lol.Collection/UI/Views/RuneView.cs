using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.Collection.UI.Views
{
    public class RuneView : View
    {
        #region DefaultStyleKey


        static RuneView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RuneView), new FrameworkPropertyMetadata(typeof(RuneView)));
        }
        #endregion
    }
}
