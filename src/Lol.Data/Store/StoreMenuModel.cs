using System.Windows.Input;

namespace Lol.Data.Store
{
    public class StoreMenuModel
    {
        public int Seq { get; set; }
        public string Name { get; set; }
        public ICommand MenuSelectCommand { get; set; }

        public StoreMenuModel(int seq, string name)
        {
            Seq = seq;
            Name = name;
        }
    }
}
