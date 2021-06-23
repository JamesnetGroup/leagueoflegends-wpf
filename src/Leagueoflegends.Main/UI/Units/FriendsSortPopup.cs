using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Main.UI.Units
{
	public class FriendsSortPopup : ContentControl
	{
		static FriendsSortPopup()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(FriendsSortPopup), new FrameworkPropertyMetadata(typeof(FriendsSortPopup)));
		}
	}
}
