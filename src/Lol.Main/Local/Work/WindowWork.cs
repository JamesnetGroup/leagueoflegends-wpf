using Lol.Main.Local.ViewModel;
using System.Windows;

namespace Lol.Main.Local.Work
{
	public class WindowWork
	{
		public WindowWork(MainViewModel view)
		{
			_ = view;
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
