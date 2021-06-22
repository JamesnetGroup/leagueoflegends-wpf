using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Friends.Views
{
	public class DoneButton : Button
	{
		#region DefaultStyleKey

		static DoneButton()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(DoneButton), new FrameworkPropertyMetadata(typeof(DoneButton)));
		}
		#endregion
	}
}
