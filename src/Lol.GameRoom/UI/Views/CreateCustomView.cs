using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;

namespace Lol.GameRoom.UI.Views
{
    public class CreateCustomView : View
    {
        #region DefalutStyleKey

        static CreateCustomView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CreateCustomView), new FrameworkPropertyMetadata(typeof(CreateCustomView)));
        }
        #endregion
    }
}
