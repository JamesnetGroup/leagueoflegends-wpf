using Lol.LayoutSupport.Controls;
using System.Windows;

namespace Lol.TeamFight.UI.Views
{
	public class TeamFightView : View
	{
		static TeamFightView()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(TeamFightView), new FrameworkPropertyMetadata(typeof(TeamFightView)));
		}
	}
}
