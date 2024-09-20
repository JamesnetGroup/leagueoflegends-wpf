using System.Windows;
using System.Windows.Controls;

namespace Lol.Clash.UI.Units
{
    public class FaqButton : Button
    {
        #region DefaultStyleKey

        static FaqButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FaqButton), new FrameworkPropertyMetadata(typeof(FaqButton)));
        }
        #endregion
    }
}
