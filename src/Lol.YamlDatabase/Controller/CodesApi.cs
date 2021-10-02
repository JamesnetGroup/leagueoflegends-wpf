using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Lol.YamlDatabase.Controller
{
    public class CodesApi : LolDbContext
    {
        public List<UsualCodes> GetCodes(string codeId)
        {
            var items = Db.CodeItems
                .Where(x => x.CodeId == codeId)
                .OrderBy(x => x.Sort)
                .Select(x => new UsualCodes(x));

            return items.ToList();
        }
    }
}
