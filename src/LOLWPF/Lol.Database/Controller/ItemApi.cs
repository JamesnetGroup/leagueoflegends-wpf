using Lol.Database.Entites.Core;
using Lol.Database.Entites.Schema;

namespace Lol.Database.Controller
{
    public class ItemApi : LolDbContext
    {
        #region GetItems

        public List<Items> GetItems()
        {
            var query = from i in Db.Items
                        select new Items
                        {
                            Seq = i.Seq,
                            Name = i.Name,
                            Champ = i.Champ,
                            MapTypeItems = Db.MapTypes.Where(y => i.MapTypes.Contains(y.Id)),
                            IsChecked = false
                        };
            return query.ToList();
        }
        #endregion
    }
}
