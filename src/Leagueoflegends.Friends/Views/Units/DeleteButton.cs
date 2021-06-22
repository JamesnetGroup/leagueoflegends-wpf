using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Friends.Views
{
	public class DeleteButton : Button
	{
		#region DefaultStyleKey

		static DeleteButton()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(DeleteButton), new FrameworkPropertyMetadata(typeof(DeleteButton)));
		}
		#endregion
	}
}
