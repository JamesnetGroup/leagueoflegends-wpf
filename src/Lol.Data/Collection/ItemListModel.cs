using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lol.Data.Collection
{
    public class ItemListModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private int _Seq;
        public int Seq
        {
            get { return _Seq; }
            set { _Seq = value; OnPropertyChanged(); }
        }


        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; OnPropertyChanged(); }
        }


        private string _Champ;
        public string Champ
        {
            get { return _Champ; }
            set { _Champ = value; OnPropertyChanged(); }
        }


        private string _MapType1;
        public string MapType1
        {
            get { return _MapType1; }
            set { _MapType1 = value; OnPropertyChanged(); }
        }


        private string _MapType2;
        public string MapType2
        {
            get { return _MapType2; }
            set { _MapType2 = value; OnPropertyChanged(); }
        }


    }
}
