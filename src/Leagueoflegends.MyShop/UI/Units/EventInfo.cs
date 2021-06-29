using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.MyShop.UI.Units
{
	public class EventInfo : Control
    {
        static EventInfo()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(EventInfo), new FrameworkPropertyMetadata(typeof(EventInfo)));
        }
    }
}
