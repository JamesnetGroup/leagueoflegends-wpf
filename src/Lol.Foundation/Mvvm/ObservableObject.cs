using System.ComponentModel;
using System.Runtime.CompilerServices;
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

        internal void InitRegistUI(IRiotUI _view)
        {
            View = _view;
        }
    }
}