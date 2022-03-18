using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;

namespace Lol.GameRoom.UI.Views
{
    public class SummonersRiftView : View
    {
        #region DefaultStyleKey

        static SummonersRiftView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SummonersRiftView), new FrameworkPropertyMetadata(typeof(SummonersRiftView)));
        }
        #endregion
    }
}
