using Leagueoflegends.Windowbase.Riotcore;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Leagueoflegends.Windowbase.Mvvm
{
	public class ObservableObject : INotifyPropertyChanged
	{
		protected IRiotUI View;

		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}

		internal void InitRegistUI(IRiotUI _view)
		{
			View = _view;
		}
	}
}