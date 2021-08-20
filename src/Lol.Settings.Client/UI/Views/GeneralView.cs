using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.Settings.Client.UI.Views
{
    public class GeneralView : View
    {
        #region DefaultStyleKey

        static GeneralView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GeneralView), new FrameworkPropertyMetadata(typeof(GeneralView)));
        }
        #endregion
    }
}
