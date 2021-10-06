using Lol.YamlDatabase.Entites.Statics;

namespace Lol.YamlDatabase.Entites.Core
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
