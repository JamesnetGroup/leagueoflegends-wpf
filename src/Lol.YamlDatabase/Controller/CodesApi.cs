using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Lol.YamlDatabase.Controller
{
    public class CodesApi : LolDbContext
    {
        public List<UsualCodes> GetCodes(string codeId)
        {
            var items = Db.CodeItems
                .Where(x => x.CodeId == codeId)
                .OrderBy(x => x.Sort)
                .Select(x => new UsualCodes(x))
                .ToList();

            return items;
        }
    }
}
