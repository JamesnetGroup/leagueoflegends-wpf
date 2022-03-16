using DevNcore.UI.Foundation.Mvvm;
using Lol.Data.Collection;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Lol.Collection.Local.Model
{
    public class MyItemListModel : ItemListModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private bool _isChecked;

        public MyItemListModel()
        {

        }

        public MyItemListModel(ItemListModel x, Action<object> method)
        {
            Seq = x.Seq;
            Name = x.Name;
            Champ = x.Champ;
            MapType1 = x.MapType1;
            MapType2 = x.MapType2;
            CheckCommand = new RelayCommand<object>(method);
        }

        public ICommand CheckCommand { get; set; }
        public bool IsChecked
        {
            get => _isChecked;
            set { _isChecked = value; OnPropertyChanged(); }
        }
    }
}
