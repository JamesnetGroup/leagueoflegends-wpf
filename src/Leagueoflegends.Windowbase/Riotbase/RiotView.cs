using Leagueoflegends.Windowbase.Mvvm;
using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Windowbase.Riotbase
{
	public class RiotView : UserControl
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
	}
}
