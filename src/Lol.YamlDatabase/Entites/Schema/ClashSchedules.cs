using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.YamlDatabase.Entites.Schema
{
    public class ClashSchedules
    {
        public int Seq { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime EndDate { get; set; }
    }
}
