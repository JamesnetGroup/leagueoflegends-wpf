using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Leagueoflegends.Windowbase.Mvvm
{
	public class ObservableObject : INotifyPropertyChanged
	{
		protected UIElement View;

		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}

		internal void InitRegistUI(UIElement _view)
		{
			View = _view;
		}
	}
}