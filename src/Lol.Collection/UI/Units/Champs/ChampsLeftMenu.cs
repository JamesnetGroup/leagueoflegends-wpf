using System.Windows;
using System.Windows.Controls;

namespace Lol.Collection.UI.Units
{
    public class ChampsLeftMenu : Control
    {
        #region DefaultStyleKey

        static ChampsLeftMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChampsLeftMenu), new FrameworkPropertyMetadata(typeof(ChampsLeftMenu)));
        }
        #endregion
    }
}
