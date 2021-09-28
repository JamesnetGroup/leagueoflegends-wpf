using Lol.Main.Local.ViewModel;
using System.Windows;

namespace Lol.Main.Local.Work
{
    public class WindowWork
    {
        #region Constructor

        public WindowWork(MainViewModel view)
        {
            _ = view;
        }
        #endregion

        #region DoClosing

        internal void DoClosing(object ui)
        {
            Window.GetWindow((UIElement)ui).Close();
        }
        #endregion

        #region DoMinizing

        internal void DoMinizing(object ui)
        {
            Window.GetWindow((UIElement)ui).WindowState = WindowState.Minimized;
        }
        #endregion
    }
}
