using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Main.Views
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
