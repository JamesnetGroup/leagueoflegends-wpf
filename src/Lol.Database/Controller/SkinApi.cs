using Lol.Database.Entites.Core;
using Lol.Database.Entites.Schema;

namespace Lol.Database.Controller
{
    public class SkinApi : LolDbContext
    {
        #region GetSkinFilter1

        public List<SkinFilter> GetSkinFilter1()
        {
            var query = from c in Db.SkinFilter
                        where c.Type == 0
                        select new SkinFilter
                        {
                            Seq = c.Seq,
                            Content = c.Content,
                            Type = c.Type
                        };
            return query.ToList();
        }
        #endregion

        #region GetChampFilter2

        public List<SkinFilter> GetSkinFilter2(int viewType)
        {
            var query = from c in Db.SkinFilter
                        where c.Type == 1 && c.ViewType == viewType
                        select new SkinFilter
                        {
                            Seq = c.Seq,
                            Content = c.Content,
                            Type = c.Type
                        };
            return query.ToList();
        }
        #endregion
    }
}
