using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.Profile.UI.Views
{
    public class HighlightView : View
    {
        #region DefalutStyleKey


        static HighlightView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HighlightView), new FrameworkPropertyMetadata(typeof(HighlightView)));
        }
        #endregion
    }
}
