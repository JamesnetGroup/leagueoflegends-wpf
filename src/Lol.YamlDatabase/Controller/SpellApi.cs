using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;

namespace Lol.YamlDatabase.Controller
{
    public class SpellApi : LolDbContext
    {
        public List<Spells> GetSpells()
        {
            var playTypes = Db.PlayTypes;
            var spells = Db.Spells;
            spells.ForEach(x => x.PlayTypeItems = playTypes.Where(y=>x.PlayTypes.Contains(y.Id)).ToList());
            return spells;
        }
    }
}
