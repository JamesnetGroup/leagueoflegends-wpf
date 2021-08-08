using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Home.General.UI.Units
{
    public class Rotation : Control
    {
        static Rotation()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Rotation), new FrameworkPropertyMetadata(typeof(Rotation)));
        }
    }
}
