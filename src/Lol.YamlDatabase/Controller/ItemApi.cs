using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Lol.YamlDatabase.Controller
{
    public class ItemApi : LolDbContext
    {
        private static string ImgResource(string folder, string name)
        {
            return $"/Lol.Resources;component/Images/{folder}/{name}.png";
        }

        public List<Items> GetItems()
        {
            var query = from i in Db.Items
                        select new Items
                        {
                            Seq = i.Seq,
                            Name = i.Name,
                            Champ = i.Champ,
                            MapTypeItems = Db.MapTypes.Where(y => i.MapTypes.Contains(y.Id))
                        };
            return query.ToList();
        }
    }
}
