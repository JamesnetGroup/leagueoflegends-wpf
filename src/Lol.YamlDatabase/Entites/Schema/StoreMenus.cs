using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lol.YamlDatabase.Entites.Schema
{
    public class StoreMenus
    {
        public int Seq { get; set; }
        public string Name { get; set; }
        public ICommand MenuSelectCommand { get; set; }

        //public StoreMenus(int seq, string name)
        //{
        //    Seq = seq;
        //    Name = name;
        //}
    }
}
