using Lol.Database.Entites.Core;
using Lol.Database.Entites.Schema;

namespace Lol.Database.Controller
{
    public class CodesApi : LolDbContext
    {
        #region GetCodes

        public List<UsualCodes> GetCodes(string codeId)
        {
            var items = Db.CodeItems
                .Where(x => x.CodeId == codeId)
                .OrderBy(x => x.Sort)
                .Select(x => new UsualCodes(x));

            return items.ToList();
        }
        #endregion
    }
}
