using Leagueoflegends.Windowbase.Mvvm;
using System.Windows.Input;

namespace Leagueoflegends.TitleBar.ViewModels
{
	public class TitleBarViewModel : ObservableObject
	{
		public ICommand TitleBarSelectCommand { get; }

		public TitleBarViewModel(RelayCommand<object> titlebarCommand)
		{
			TitleBarSelectCommand = titlebarCommand;
		}
	}
}
