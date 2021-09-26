using Lol.YamlDatabase.Entites.Statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.YamlDatabase.Entites.Core
{
    public class LolDbContext
    {
        protected LolDataPack Db { get; private set; }

        public LolDbContext()
        {
            Db = LolDataPack.Instance;
        }
    }
}
