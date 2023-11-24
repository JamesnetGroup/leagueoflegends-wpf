using Lol.Database.Entites.Core;
using Lol.Database.Entites.Schema;

namespace Lol.Database.Controller
{
    public class TeamFightApi : LolDbContext
    {
        #region GetTeamFights

        public List<TeamFights> GetTeamFights()
        {
            var items = from s in Db.TeamFights
                        select new TeamFights
                        {
                            Seq = s.Seq,
                            Name = s.Name,
                            Explain = s.Explain,
                            Level = s.Level,
                            Image = s.Image,
                            IsFree = s.IsFree,
                            IsPremium = s.IsPremium
                        };
            return items.ToList();
        }
        #endregion
    }
}
