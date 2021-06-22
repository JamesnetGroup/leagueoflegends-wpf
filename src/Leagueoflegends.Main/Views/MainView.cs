using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Main.Views
{
	public class MainView : MainWindow
	{
		#region DefaultStyleKey

		static MainView()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(MainView), new FrameworkPropertyMetadata(typeof(MainView)));
		}
		#endregion
	}
}
