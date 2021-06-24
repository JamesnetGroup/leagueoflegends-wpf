using Leagueoflegends.Data.Main;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotcore;
using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Foundation.Riotbase
{
	public class RiotView : UserControl, IRiotUI
	{
		public RiotView()
		{
			Loaded += RiotView_Loaded;
		}

		private void RiotView_Loaded(object sender, RoutedEventArgs e)
		{
			if (DataContext is ObservableObject vm)
			{
				vm.InitRegistUI(this);
			}
		}

		public IRiotUI SetVM(ObservableObject vm)
		{
			DataContext = vm;
			return this;
		}

		public void Show(SubMenuModel menu)
		{
		}
	}
}
