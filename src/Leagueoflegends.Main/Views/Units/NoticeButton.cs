using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Main.Views
{
	public class NoticeButton : Button
	{
		static NoticeButton()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(NoticeButton), new FrameworkPropertyMetadata(typeof(NoticeButton)));
		}
	}
}
