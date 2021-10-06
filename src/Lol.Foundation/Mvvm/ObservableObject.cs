using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Lol.Foundation.Riotcore;

namespace Lol.Foundation.Mvvm
{
    public class ObservableObject : INotifyPropertyChanged
    {
        protected IRiotUI View;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        protected virtual void OnLoaded(Window window)
        {
            //   asdasd
        }

        internal void InitRegistUI(IRiotUI _view)
        {
            View = _view;
            OnLoaded(View as Window);
        }
    }
}