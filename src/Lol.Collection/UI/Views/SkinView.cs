using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.Collection.UI.Views
{
    public class SkinView : View
    {
        #region DefaultStyleKey

        static SkinView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SkinView), new FrameworkPropertyMetadata(typeof(SkinView)));
        }
        #endregion
    }
}
