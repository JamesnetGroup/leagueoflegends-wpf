using Leagueoflegends.Data.Main;
using Leagueoflegends.Windowbase.Mvvm;
using Leagueoflegends.Windowbase.Riotcore;
using System.Windows;

namespace Leagueoflegends.Windowbase.Riotbase
{
	public class RiotWindow : Window, IRiotUI
	{
		public RiotWindow()
		{
			Loaded += RiotWindow_Loaded;
		}

		public void Show(SubMenuModel menu)
		{
		}

		public IRiotUI SetVM(ObservableObject vm)
		{
			DataContext = vm;
			return this;
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
