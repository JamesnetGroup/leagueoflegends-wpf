using Lol.Database.Common;
using Lol.Database.Entites.Core;
using Lol.Database.Entites.Schema;

namespace Lol.Database.Controller
{
    public class LootApi : LolDbContext
    {
        #region GetCategory

        public List<Loots> GetCategory()
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

        #region GetLootItems

        public List<Loots> GetLootSummary()
        {
            var query = from i in Db.LootSummary
                        select new Loots
                        {
                            Seq = i.Seq,
                            Name = i.Name,
                            Type = i.Type,
                            Value = i.Value,
                        };
            return query.ToList();
        }
        #endregion

        #region GetPlantHeaders

        public List<PlantHeaders> GetPlantHeaders()
        {
            Db.PlantItems.ForEach(x => x.Content = ResourceHelper.ImgResource(x.Content));

            var query = from i in Db.PlantHeaders
                        select new PlantHeaders
                        {
                            Seq = i.Seq,
                            IsExpanded = i.IsExpanded,
                            LootSeq = i.LootSeq,
                            Children = Db.PlantItems.Where(x => x.HeaderSeq == i.Seq).ToList(),
                            Header = i.Header,
                        };
            return query.ToList();
        }
        #endregion

        #region GetFilters

        public List<LootItemSortings> GetFilters()
        {
            var query = from c in Db.LootItemSortings
                        select new LootItemSortings
                        {
                            Seq = c.Seq,
                            Content = c.Content
                        };
            return query.ToList();
        }
        #endregion
    }
}
