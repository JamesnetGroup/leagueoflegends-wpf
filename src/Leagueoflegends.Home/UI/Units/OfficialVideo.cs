using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Home.UI.Units
{
    public class OfficialVideo : Control
    {
        #region DefaultStyleKey

        static OfficialVideo()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(OfficialVideo), new FrameworkPropertyMetadata(typeof(OfficialVideo)));
        }
		#endregion
	}
}
