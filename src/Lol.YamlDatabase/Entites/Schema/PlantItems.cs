using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.YamlDatabase.Entites.Schema
{
    public class PlantHeaders
    {
        public int Seq { get; set; }
        public bool IsExpanded { get; set; } = true;
        public List<PlantItems> Children { get; set; }
        public string Header { get; set; }
    }

    public class PlantItems
    {
        public int Seq { get; set; }
        public int HeaderSeq { get; set; }
        public string Content { get; set; }
    }
}
