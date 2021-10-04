using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;

namespace Lol.YamlDatabase.Controller
{
    public class ClashCupApi : LolDbContext
    {
        public List<ClashTabs> GetClashTabs()
        {
            var items = from s in Db.ClashTabs
                        select new ClashTabs
                        {
                            Seq = s.Seq,
                            Name = s.Name
                        };

            return items.ToList();
        }

        public List<ClashCups> GetClashCups()
        {
            var items = from s in Db.ClashCups
                        select new ClashCups
                        {
                            Seq = s.Seq,
                            Name = s.Name
                        };

            return items.ToList();
        }

        public List<ClashTiers> GetClashTiers()
        {
            var items = from s in Db.ClashTiers
                        select new ClashTiers
                        {
                            Seq = s.Seq,
                            Name = s.Name
                        };

            return items.ToList();
        }

        public List<ClashTierDetails> GetClashTierDetails(int seq)
        {
            var items = from s in Db.ClashTierDetails
                        where s.ParentSeq == seq
                        select new ClashTierDetails
                        {
                            Seq = s.Seq,
                            ParentSeq = s.ParentSeq,
                            Id = s.Id,
                            Name = s.Name,
                            SubName = s.SubName,
                            Time = s.Time
                        };

            return items.ToList();
        }

        public List<ClashSchedules> GetClashSchedules()
        {
            var items = from s in Db.ClashSchedules
                        select new ClashSchedules
                        {
                            Seq = s.Seq,
                            Name = s.Name,
                            Created = s.Created,
                            EndDate = s.EndDate,
                        };

            return items.ToList();
        }
    }
}
