using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Main.UI.Units
{
	public class FriendsListItem : Control
	{
		#region DefaultStyleKey

		static FriendsListItem()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(FriendsListItem), new FrameworkPropertyMetadata(typeof(FriendsListItem)));
		}
		#endregion
	}
}
