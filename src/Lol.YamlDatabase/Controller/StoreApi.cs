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
        public List<StoreMenus> GetCategory()
        {
            var query = from s in Db.StoreMenus
                        select new StoreMenus
                        {
                            Seq = s.Seq,
                            Name = s.Name,
                        };
            return query.ToList();
        }
    }
}
