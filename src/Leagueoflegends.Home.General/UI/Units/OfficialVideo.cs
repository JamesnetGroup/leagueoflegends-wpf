using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Home.General.UI.Units
{
    public class OfficialVideo : Control
    {
        static OfficialVideo()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(OfficialVideo), new FrameworkPropertyMetadata(typeof(OfficialVideo)));
        }
    }
}
