using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;
using System.Collections.Generic;
using System.Linq;

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
                            MapTypeItems = Db.MapTypes.Where(y => i.MapTypes.Contains(y.Id)),
                            IsChecked = false
                        };
            return query.ToList();
        }
    }
}
