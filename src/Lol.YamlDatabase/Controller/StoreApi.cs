using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.YamlDatabase.Controller
{
    public class StoreApi : LolDbContext
    {
        public List<StoreChampTypes> GetCategory()
        {
            var query = from s in Db.StoreChampTypes
                        select new StoreChampTypes
                        {
                            Seq = s.Seq,
                            Name = s.Name,
                        };
            return query.ToList();
        }
    }
}
