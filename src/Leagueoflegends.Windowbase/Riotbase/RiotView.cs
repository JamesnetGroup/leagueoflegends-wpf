using Leagueoflegends.Data.Main;
using Leagueoflegends.Windowbase.Mvvm;
using Leagueoflegends.Windowbase.Riotcore;
using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Windowbase.Riotbase
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

		public IRiotUI UseViewModel(ObservableObject vm)
		{
			DataContext = vm;
			return this;
		}

		public void Show(SubMenuModel menu)
		{
		}
	}
}
