using Lol.YamlDatabase.Common;
using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;

namespace Lol.YamlDatabase.Controller
{
    public class StoreApi : LolDbContext
    {
        #region GetCategory

        public List<StoreChampTypes> GetCategory()
        {
            var query = from s in Db.StoreChampTypes
                        select new StoreChampTypes
                        {
                            Seq = s.Seq,
                            Name = s.Name,
                        };
            return query.ToList();
        }
        #endregion

        #region GetSorting

        public List<StoreChampSortings> GetSorting(string id)
        {
            var query = from s in Db.StoreChampSortings
                        where s.Id == id
                        select new StoreChampSortings
                        {
                            Seq = s.Seq,
                            Id = s.Id,
                            Name = s.Name,
                            Option = s.Option
                        };
            return query.ToList();
        }
        #endregion

        #region GetChamps

        public List<StoreChamps> GetChamps()
        {
            var query = from s in Db.StoreChamps
                        select new StoreChamps
                        {
                            Seq = s.Seq,
                            Name = s.Name,
                            ImgSource = ResourceHelper.ImgResource(s.ImgSource),
                            RP = s.RP,
                            BE = s.BE,
                        };
            return query.ToList();
        }
        #endregion
    }
}
