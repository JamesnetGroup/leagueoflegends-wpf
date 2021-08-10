using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Home.UI.Units
{
    public class Rotation : Control
    {
        #region DefaultStyleKey

        static Rotation()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Rotation), new FrameworkPropertyMetadata(typeof(Rotation)));
        }
		#endregion
	}
}
