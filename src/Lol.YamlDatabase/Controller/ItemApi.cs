using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;

namespace Lol.YamlDatabase.Controller
{
    public class ItemApi : LolDbContext
    {
        private static string ImgResource(string folder, string name)
        {
            return $"/Lol.Resources;component/Images/{folder}/{name}.png";
        }

        public List<Items> GetItems()
        {
            var query = from i in Db.Items
                        select new Items
                        {
                            Seq = i.Seq,
                            Name = i.Name,
                            Champ = i.Champ,
                            MapTypeStr1 = ImgResource(i.MapType1[0].ToString(), i.MapType1[1].ToString()),
                            MapTypeStr2 = ImgResource(i.MapType2[0].ToString(), i.MapType2[1].ToString()),

                        };
            return query.ToList();
        }
    }
}
