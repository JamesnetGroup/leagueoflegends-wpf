using Lol.YamlDatabase.Entites.Statics;

namespace Lol.YamlDatabase.Entites.Core
{

    public class LolDbContext
    {
        protected LolDataPack Db { get; private set; }

        public LolDbContext()
        {
            Db = LolDataPack.Instance;
        }
    }
}
