using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.YamlDatabase.Entites.Schema
{
    public class CodeItems
    {
        public int Seq { get; set; }
        public string Id { get; set; }
        public string CodeId { get; set; }
        public string ItemName { get; set; }
        public string ItemValue { get; set; }
        public string Explain { get; set; }
        public int Sort { get; set; }
    }
}
