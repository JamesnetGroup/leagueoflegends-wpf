using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Client.Block.UI
{
	public class ClientBlockView : View
    {
        #region ClientBlockView

        static ClientBlockView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ClientBlockView), new FrameworkPropertyMetadata(typeof(ClientBlockView)));
        }
		#endregion
	}
}
