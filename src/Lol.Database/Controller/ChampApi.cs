using Lol.Database.Common;
using Lol.Database.Entites.Core;
using Lol.Database.Entites.Schema;

namespace Lol.Database.Controller
{
    public class ChampApi : LolDbContext
    {
        #region GetChampFilter1

        public List<ChampFilter> GetChampFilter1()
        {
            var query = from c in Db.ChampFilter
                        where c.Type == 0
                        select new ChampFilter
                        {
                            Seq = c.Seq,
                            Content = c.Content,
                            Type = c.Type
                        };
            return query.ToList();
        }
        #endregion

        #region GetChampFilter2

        public List<ChampFilter> GetChampFilter2()
        {
            var query = from c in Db.ChampFilter
                        where c.Type == 1
                        select new ChampFilter
                        {
                            Seq = c.Seq,
                            Content = c.Content,
                            Type = c.Type
                        };
            return query.ToList();
        }
        #endregion

        public List<ChampHeaders> GetChampHeaders()
        {
            Db.ChampItems.ForEach(x => {
                x.Img = ResourceHelper.ImgResource(x.Img);
                x.Insignia = ResourceHelper.ImgResource(x.Insignia);
            });

            var query = from c in Db.ChampHeaders
                        select new ChampHeaders
                        {
                            Seq = c.Seq,
                            ChampCbSeq = c.ChampCbSeq,
                            Children = Db.ChampItems.Where(x => x.HeaderSeq == c.Seq).OrderBy(y => y.Name).ToList(),
                            Header = c.Header,
                            IsExpanded =  c.IsExpanded
                        };

            return query.ToList();
        }
    }
}
