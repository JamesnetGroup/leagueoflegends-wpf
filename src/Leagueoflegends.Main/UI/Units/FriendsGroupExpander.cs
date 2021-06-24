using System.Windows;
using System.Windows.Controls.Primitives;

namespace Leagueoflegends.Main.UI.Units
{
	public class FriendsGroupExpander : ToggleButton
	{
		#region DefaultStyleKey

		static FriendsGroupExpander()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(FriendsGroupExpander), new FrameworkPropertyMetadata(typeof(FriendsGroupExpander)));
		}
		#endregion
	}
}
