using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;

namespace Lol.GameRoom.UI.Views
{
    public class JoinCustomView : View
    {
        #region DefaultStyleKey

        static JoinCustomView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(JoinCustomView), new FrameworkPropertyMetadata(typeof(JoinCustomView)));
        }
        #endregion
    }
}
