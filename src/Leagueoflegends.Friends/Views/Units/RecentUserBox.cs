using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Friends.Views
{
	public class RecentUserBox : ListBox
	{
		#region DefaultStyleKey

		static RecentUserBox()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(RecentUserBox), new FrameworkPropertyMetadata(typeof(RecentUserBox)));
		}
		#endregion
	}
}
