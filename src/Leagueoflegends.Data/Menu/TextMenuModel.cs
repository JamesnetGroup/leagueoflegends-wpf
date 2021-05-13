using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Leagueoflegends.Data.Menu
{
    public class MenuBoxModel
    {
        public string Name { get; set; }
        public ICommand MenuSelectCommand { get; set; }

        public MenuBoxModel(string name)
        {
            Name = name;
        }
    }
}
