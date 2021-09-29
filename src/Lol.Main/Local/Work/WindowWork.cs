using System.Windows;

namespace Lol.Main.Local.Work
{
    public class WindowWork
    {
        #region Variables

        private object _ui;
        #endregion

        #region Constructor

        public WindowWork()
        {
            _= _ui;
        }
        #endregion

        #region DoClosing

        internal void DoClosing(object ui)
        {
            _ui = ui;
            Window.GetWindow((UIElement)ui).Close();
        }
        #endregion

        #region DoMinizing

        internal void DoMinizing(object ui)
        {
            _ui = ui;
            Window.GetWindow((UIElement)ui).WindowState = WindowState.Minimized;
        }
        #endregion
    }
}
