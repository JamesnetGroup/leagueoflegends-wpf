using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Main.Views
{
	public class MainMenu : Control
	{
		static MainMenu()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(MainMenu), new FrameworkPropertyMetadata(typeof(MainMenu)));
		}

		public MainMenu()
		{
		}
	}
}