using Lol.Database.Common;
using Lol.Database.Entites.Core;
using Lol.Database.Entites.Schema;

namespace Lol.Database.Controller
{
    public class HistoryApi : LolDbContext
    {
        #region GetHistories

        public List<History> GetHistory()
        {
            var query = from i in Db.History
                        select new History
                        {
                            Seq = i.Seq,
                            MapType = i.MapType,
                            GameType = i.GameType,
                            Result = i.Result,
                            Created = i.Created,
                            GameTime = i.GameTime,
                            GameDate = i.GameDate,
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
        #endregion

        #region GetActivities

        public List<History> GetActivities()
        {
            var query = from i in Db.Activities
                        select new History
                        {
                            Seq = i.Seq,
                            ActivePercent = i.ActivePercent,
                            Concept = ResourceHelper.ImgResource(i.Concept),
                            ConceptName = i.ConceptName,
                        };
            return query.ToList();
        }
        #endregion

        #region GetPlayChampions

        public List<History> GetPlayChampions()
        {
            var query = from i in Db.PlayChampions
                        select new History
                        {
                            Seq = i.Seq,
                            Champion = ResourceHelper.ImgResource(i.Champion),
                            Percent = i.Percent,
                        };
            return query.ToList();
        }
        #endregion
    }
}
