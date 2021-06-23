using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Main.UI.Units
{
	public class FriendsList : TreeView
	{
		#region DefaultStyleKey

		static FriendsList()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(FriendsList), new FrameworkPropertyMetadata(typeof(FriendsList)));
		}
		#endregion
	}
}
