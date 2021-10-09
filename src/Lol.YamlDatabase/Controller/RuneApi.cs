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
                            RuneStone = ResourceHelper.ImgResource(r.RuneStone),
                            Rune = ResourceHelper.ImgResource(r.Rune),
                            Keystone = ResourceHelper.ImgResource(r.Keystone),
                            Paths = ResourceHelper.ImgResource(r.Paths),
                            RunType = r.RunType

                        };
            return query.ToList();
        }
    }
}
