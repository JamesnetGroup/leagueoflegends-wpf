using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.YamlDatabase.Controller
{
    public class ItemApi : LolDbContext
    {
        public List<Items> GetItems()
        {
            var query = from i in Db.Items
                        select new Items
                        {
                            Seq = i.Seq,
                            Name = i.Name,
                            Champ = i.Champ,
                            MapType1 = i.MapType1,
                            MapType2 = i.MapType2

                        };
            return query.ToList();
        }
    }
}
