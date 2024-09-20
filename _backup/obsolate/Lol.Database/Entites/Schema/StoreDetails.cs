using System.Windows.Input;

namespace Lol.Database.Entites.Schema
{
    public class StoreDetails
    {
        public int Seq { get; set; }
        public int TypeSeq { get; set; }
        public string Name { get; set; }
        public ICommand MenuSelectCommand { get; set; }
    }
}
