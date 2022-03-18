using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;

namespace Lol.Store.UI.Views
{
    public class TFTView : View
    {
        #region DefaultStyleKey

        static TFTView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TFTView), new FrameworkPropertyMetadata(typeof(TFTView)));
        }
        #endregion
    }
}
