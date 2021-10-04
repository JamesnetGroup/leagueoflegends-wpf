using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.YamlDatabase.Controller
{
    public class RuneApi : LolDbContext
    {
        public List<Runes> GetRunes()
        {
            var query = from r in Db.Runes
                        select new Runes
                        {
                            Seq = r.Seq,
                            Name = r.Name
                        };
            return query.ToList();
        }
    }
}
