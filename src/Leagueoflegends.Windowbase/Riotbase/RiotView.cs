using Leagueoflegends.Data.Menu;
using Leagueoflegends.Windowbase.Mvvm;
using Leagueoflegends.Windowbase.Riotcore;
using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Windowbase.Riotbase
{
	public class RiotView : UserControl, IRiotUIElement
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

		public void Show(SubMenuModel menu)
		{
		}

		public IRiotUIElement UseViewModel(ObservableObject vm)
		{
			DataContext = vm;
			return this;
		}

	}
}
