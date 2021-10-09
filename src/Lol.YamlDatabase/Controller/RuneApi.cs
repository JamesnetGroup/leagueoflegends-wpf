using Lol.YamlDatabase.Common;
using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;

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
                            Name = ResourceHelper.ImgResource(r.Name),
                            Test = ResourceHelper.ImgResource(r.Test),
                            Mark1 = ResourceHelper.ImgResourceJpg(r.Mark1),
                            Mark2 = ResourceHelper.ImgResource(r.Mark2)

                        };
            return query.ToList();
        }
    }
}
