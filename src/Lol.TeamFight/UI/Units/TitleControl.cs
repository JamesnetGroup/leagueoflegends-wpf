using System.Windows;
using System.Windows.Controls;

namespace Lol.TeamFight.UI.Units
{
	public class TitleControl : Control
	{
		static TitleControl()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(TitleControl), new FrameworkPropertyMetadata(typeof(TitleControl)));
		}
	}
}
