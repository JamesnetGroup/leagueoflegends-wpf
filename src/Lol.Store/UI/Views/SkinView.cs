using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;

namespace Lol.Store.UI.Views
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
