using Leagueoflegends.Main.ViewModels;
using System.Windows;

namespace Leagueoflegends.Main.Local.Works
{
	public class WindowWork
	{
		private readonly MainViewModel _view;

		public WindowWork(MainViewModel view)
		{
			_view = view;
		}

		internal void DoClosing(object ui)
		{
			Window.GetWindow((UIElement)ui).Close();
		}

		internal void DoMinizing(object ui)
		{
			Window.GetWindow((UIElement)ui).WindowState = WindowState.Minimized;
		}
	}
}
