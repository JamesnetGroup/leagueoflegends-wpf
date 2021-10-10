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

                        };
            return query.ToList();
        }

        public List<RunesDetail> GetRunesDetail()
        {
            var query = from r in Db.RunesDetail
                        select new RunesDetail
                        {
                            Seq = r.Seq,
                            Rune = ResourceHelper.ImgResource(r.Rune),
                            Keystone = ResourceHelper.ImgResource(r.Keystone),
                            Paths = ResourceHelper.ImgResource(r.Paths),
                            RunType = r.RunType,
                            Name = r.Name,
                            Infor1 = r.Infor1,
                            Infor2 = r.Infor2,
                            Infor3 = r.Infor3,
                            Infor4 = r.Infor4,
                            Infor5 = r.Infor5,
                            Infor6 = r.Infor6,
                            Infor7 = r.Infor7,
                            Infor8 = r.Infor8
                        };
            return query.ToList();
        }

        public List<RunesDetail> GetRunesDetail(int seq)
        {
            return GetRunesDetail().Where(x=>x.RunType == seq.ToString()).ToList();
        }
    }
}
