using Lol.Data.Main;
using Lol.Foundation.Mvvm;
using Lol.Foundation.Riotcore;
using System.Windows;

namespace Lol.Foundation.Riotbase
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
