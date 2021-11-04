using System.Windows;
using System.Windows.Controls;

namespace Lol.Collection.UI.Units
{
    public class SkinsSummary : Control
    {
        #region DefaultStyleKey

        static SkinsSummary()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SkinsSummary), new FrameworkPropertyMetadata(typeof(SkinsSummary)));
        }
        #endregion
    }
}
