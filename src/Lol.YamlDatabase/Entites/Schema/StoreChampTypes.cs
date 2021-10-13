using System.Windows.Input;

namespace Lol.YamlDatabase.Entites.Schema
{
    public class StoreChampTypes
    {
        public int Seq { get; set; }
        public string? Name { get; set; }
        public ICommand? MenuSelectCommand { get; set; }
    }
}
