using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Lol.YamlDatabase.Controller
{
    public class LootApi : LolDbContext
    {
        #region GetLoots

        public List<Loots> GetLoots()
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

        public List<Loots> GetLootItems()
        {
            var query = from i in Db.LootItems
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
            var query = from i in Db.PlantHeaders
                        select new PlantHeaders
                        {
                            IsExpanded = i.IsExpanded,
                            Header = i.Header,
                        };
            return query.ToList();
        }
        #endregion

        #region GetComboBox

        public List<ChampCb> GetComboBox()
        {
            var query = from c in Db.ChampCb
                        where c.Type == 3
                        select new ChampCb
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
