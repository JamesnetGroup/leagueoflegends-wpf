using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.Data.WinningTeam
{
    public class CupModel
    {
        public int Seq { get; set; }
        public string Name { get; set; }

        public CupModel(int seq, string name)
        {
            Seq = seq;
            Name = name;
        }
    }
}
