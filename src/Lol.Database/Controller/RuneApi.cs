using Lol.Database.Common;
using Lol.Database.Entites.Core;
using Lol.Database.Entites.Schema;

namespace Lol.Database.Controller
{
    public class RuneApi : LolDbContext
    {
        #region GetRunes

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
        #endregion

        #region GetRuneDetail

        public List<RuneDetail> GetRuneDetail()
        {
            var query = from r in Db.RuneDetail
                        select new RuneDetail
                        {
                            Seq = r.Seq,
                            Rune = ResourceHelper.ImgResource(r.Rune),
                            Keystone = ResourceHelper.ImgResource(r.Keystone),
                            Paths = ResourceHelper.ImgResource(r.Paths),
                            RuneType = r.RuneType,
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

        public List<RuneDetail> GetRunesDetail(int seq)
        {
            return GetRuneDetail().Where(x => x.RuneType == seq.ToString()).ToList();
        }
        #endregion
    }
}
