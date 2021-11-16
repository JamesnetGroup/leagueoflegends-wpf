using System.Windows.Input;

namespace Lol.Database.Entites.Schema
{
    public class StoreSkinTypes
    {
        public int Seq { get; set; }
        public string Name { get; set; }
        public ICommand MenuSelectCommand { get; set; }
    }
}
