using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Main.UI.Units
{
	public class NoticeButton : Button
	{
		#region DefaultStyleKey

		static NoticeButton()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(NoticeButton), new FrameworkPropertyMetadata(typeof(NoticeButton)));
		}
		#endregion
	}
}
