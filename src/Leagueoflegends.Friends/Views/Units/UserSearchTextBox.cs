using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Friends.Views
{
	public class UserSearchTextBox : RiotTextBox
	{
		#region DefaultStyleKey

		static UserSearchTextBox()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(UserSearchTextBox), new FrameworkPropertyMetadata(typeof(UserSearchTextBox)));
		}
		#endregion
	}
}
