using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;

namespace Lol.GameRoom.UI.Views
{
    public class PVPView : View
    {
        #region DefaultStyleKey

        static PVPView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PVPView), new FrameworkPropertyMetadata(typeof(PVPView)));
        }
        #endregion
    }
}
