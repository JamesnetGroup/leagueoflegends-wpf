using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Lol.YamlDatabase.Controller
{
    public class TeamFightApi : LolDbContext
    {
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
    }
}
