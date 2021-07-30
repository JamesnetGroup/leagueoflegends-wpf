using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
	public class CastControl : Control
    {
        static CastControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CastControl), new FrameworkPropertyMetadata(typeof(CastControl)));
        }
    }
}
