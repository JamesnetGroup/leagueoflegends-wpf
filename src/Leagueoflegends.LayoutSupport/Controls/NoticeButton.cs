using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.LayoutSupport.Controls
{
	public class NoticeButton : Button
	{
		static NoticeButton()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(NoticeButton), new FrameworkPropertyMetadata(typeof(NoticeButton)));
		}
	}
}
