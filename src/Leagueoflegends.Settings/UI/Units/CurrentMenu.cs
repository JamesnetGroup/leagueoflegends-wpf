using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.UI.Units
{
	public class CurrentMenu : Control
	{
		static CurrentMenu()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(CurrentMenu), new FrameworkPropertyMetadata(typeof(CurrentMenu)));
		}
	}
}
