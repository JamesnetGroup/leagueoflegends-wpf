using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;

namespace Lol.Settings.Client.UI.Views
{
    public class BlockView : View
    {
        #region ClientBlockView

        static BlockView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BlockView), new FrameworkPropertyMetadata(typeof(BlockView)));
        }
        #endregion
    }
}
