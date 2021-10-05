using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;

namespace Lol.YamlDatabase.Controller
{
    public class SpellApi : LolDbContext
    {
        public List<Spells> GetSpells()
        {
            var query = from s in Db.Spells
                        select new Spells
                        {
                            Seq = s.Seq,
                            Name = s.Name,
                            DisplayName = s.DisplayName,
                            Content = s.Content,
                            PlayTypeItems = Db.PlayTypes.Where(y => s.PlayTypes.Contains(y.Id)),
                            Delay = s.Delay,
                            Level = s.Level
                        };
            return query.ToList();
        }
    }
}

// TODO: [James] 임시 Foreach Linq문 참고용.
//spells.ForEach(x => x.PlayTypeItems = playTypes.Where(y => x.PlayTypes.Contains(y.Id)));