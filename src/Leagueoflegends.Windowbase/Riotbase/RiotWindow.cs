using Leagueoflegends.Windowbase.Mvvm;
using System.Windows;

namespace Leagueoflegends.Windowbase.Riotbase
{
	public class RiotWindow : Window
	{
		public RiotWindow()
		{
			Loaded += RiotWindow_Loaded;
		}

		private void RiotWindow_Loaded(object sender, RoutedEventArgs e)
		{
			if (DataContext is ObservableObject vm)
			{
				vm.InitRegistUI(this);
			}
		}
	}
}
