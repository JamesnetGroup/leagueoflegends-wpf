using Lol.Data.Main;
using Lol.Foundation.Mvvm;
using Lol.Foundation.Riotcore;
using System.Windows;
using System.Windows.Controls;

namespace Lol.Foundation.Riotbase
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
