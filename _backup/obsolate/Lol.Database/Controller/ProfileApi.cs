using Lol.Database.Entites.Core;
using Lol.Database.Entites.Schema;

namespace Lol.Database.Controller
{
    public class ProfileApi : LolDbContext
    {
        public List<MyItemInfos> GetMyItemInfos()
        {
            var items = from myItem in Db.MyItemInfos
                        select new MyItemInfos
                        {
                            Seq = myItem.Seq,
                            ItemIconType = myItem.ItemIconType,
                            Count = myItem.Count,
                        };
            return items.ToList();
        }
    }
}
