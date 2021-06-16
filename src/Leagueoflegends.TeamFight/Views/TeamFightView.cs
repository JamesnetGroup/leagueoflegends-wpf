using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.TeamFight.Views
{
	public class TeamFightView : View
    {
        static TeamFightView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TeamFightView), new FrameworkPropertyMetadata(typeof(TeamFightView)));
        }
    }
}
