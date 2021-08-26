using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.Friends.UI.Views
{
	public class AddFriendsView : View
	{
		#region DefaultStyleKey

		static AddFriendsView()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(AddFriendsView), new FrameworkPropertyMetadata(typeof(AddFriendsView)));
		}
		#endregion
	}
}
