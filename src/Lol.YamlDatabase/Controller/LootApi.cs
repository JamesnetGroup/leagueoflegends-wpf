using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;

namespace Lol.YamlDatabase.Controller
{
    public class LootApi : LolDbContext
    {
        #region GetLoots

        public List<Loots> GetLoots()
        {
            var query = from i in Db.Loots
                        select new Loots
                        {
                            Seq = i.Seq,
                            Name = i.Name,
                            Type = i.Type,
                        };
            return query.ToList();
        }
        #endregion
    }
}
