using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using System.Windows;

namespace Lol.TeamFight.UI.Views
{
    public class TeamFightView : View
    {
        #region DefaultStyleKey

        static TeamFightView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TeamFightView), new FrameworkPropertyMetadata(typeof(TeamFightView)));
        }
        #endregion
    }
}
