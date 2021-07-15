using Leagueoflegends.Controls.Primitives;
using System.Windows;

namespace Leagueoflegends.LayoutSupport.Controls
{
	public class RiotIcon : Icon
    {
        #region DefaultStyleKey

        static RiotIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotIcon), new FrameworkPropertyMetadata(typeof(RiotIcon)));
        }
		#endregion
	}
}
