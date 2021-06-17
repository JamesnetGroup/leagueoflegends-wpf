using Leagueoflegends.Controls.Primitives;
using System.Windows;

namespace Leagueoflegends.Main.Views
{
	public class MainView : MainWindow
	{
		static MainView()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(MainView), new FrameworkPropertyMetadata(typeof(MainView)));
		}
	}
}
