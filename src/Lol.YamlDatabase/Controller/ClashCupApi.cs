using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Lol.YamlDatabase.Controller
{
    public class ClashCupApi : LolDbContext
    {
        public List<ClashCups> GetClashCups()
        {
            var items = from s in Db.ClashCups
                        select new ClashCups
                        {
                            Seq = s.Seq,
                            Name = s.Name
                        };

            return items.ToList();
        }
        public List<ClashTiers> GetClashTiers()
        {
            var items = from s in Db.ClashCups
                        select new ClashTiers
                        {
                            Seq = s.Seq,
                            Name = s.Name
                        };

            return items.ToList();
        }
    }
}
