using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;

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
