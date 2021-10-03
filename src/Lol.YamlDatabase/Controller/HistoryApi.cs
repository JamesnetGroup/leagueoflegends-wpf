using Lol.YamlDatabase.Common;
using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.YamlDatabase.Controller
{
    public class HistoryApi : LolDbContext
    {
        public List<Historys> GetHistorys()
        {
            var query = from i in Db.Historys
                        select new Historys
                        {
                            Seq = i.Seq,
                            MapType = i.MapType,
                            GameType = i.GameType,
                            Result = i.Result,
                            Created = i.Created,
                            GameTime = i.GameTime,
                            Money = i.Money,
                            Cs = i.Cs,
                            K = i.K,
                            D = i.D,
                            A = i.A,
                            Level = i.Level,
                            Champion = ResourceHelper.ImgResource(i.Champion),
                            Spell1 = ResourceHelper.ImgResource(i.Spell1),
                            Spell2 = ResourceHelper.ImgResource(i.Spell2),
                            Item1 = ResourceHelper.ImgResource(i.Item1),
                            Item2 = ResourceHelper.ImgResource(i.Item2),
                            Item3 = ResourceHelper.ImgResource(i.Item3),
                            Item4 = ResourceHelper.ImgResource(i.Item4),
                            Item5 = ResourceHelper.ImgResource(i.Item5),
                            Item6 = ResourceHelper.ImgResource(i.Item6),
                            Item7 = ResourceHelper.ImgResource(i.Item7),
                        };

            return query.ToList();
        }

        public List<Historys> GetActivities()
        {
            var query = from i in Db.Activities
                        select new Historys
                        {
                            Seq = i.Seq,
                            ActivePercent = i.ActivePercent,
                            Concept = ResourceHelper.ImgResource(i.Concept),
                            ConceptName =i.ConceptName,
                        };
            return query.ToList();
        }
    }
}
