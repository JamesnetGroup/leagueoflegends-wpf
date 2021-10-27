using Lol.Database.Entites.Statics;

namespace Lol.Database.Entites.Core
{
    public class LolDbContext
    {
        protected LolDataPack Db;

        public LolDbContext()
        {
            Db = LolDataPack.Instance;
        }
    }
}
