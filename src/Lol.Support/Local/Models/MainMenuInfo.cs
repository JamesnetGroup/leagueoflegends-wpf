using System.Windows.Input;

namespace Lol.Support.Local.Models
{
    public class MainMenuInfo
    {
        public int Seq { get; set; }
        public string Name { get; set; }
        public string ContentName { get; set; }
        public string MenuType { get; set; }
        public ICommand MenuSelectCommand { get; set; }

        public MainMenuInfo(int seq, string name, string type, string contentName = "")
        {
            Seq = seq;
            Name = name;
            MenuType = type;
            ContentName = contentName;
        }
    }
}
