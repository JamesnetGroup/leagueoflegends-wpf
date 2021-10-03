using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;

namespace Lol.YamlDatabase.Controller
{
    public class ChampApi : LolDbContext
    {
        public List<Champs> GetChamps()
        {
            var query = from c in Db.Champs
                        select new Champs
                        {
                            Seq = c.Seq,
                            Champ = c.Champ,
                            Name = c.Name
                        };
            return query.ToList();
        }

    }
}
