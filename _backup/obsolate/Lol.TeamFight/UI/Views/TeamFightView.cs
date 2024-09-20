using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Lol.TeamFight.UI.Views
{
    public class TeamFightView : JamesContent
    {
        static TeamFightView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TeamFightView), new FrameworkPropertyMetadata(typeof(TeamFightView)));
        }
    }
}
