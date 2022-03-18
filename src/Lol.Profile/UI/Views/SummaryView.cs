using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;

namespace Lol.Profile.UI.Views
{
    public class SummaryView : View
    {
        #region DefaultStyleKey

        static SummaryView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SummaryView), new FrameworkPropertyMetadata(typeof(SummaryView)));
        }
        #endregion
    }
}
