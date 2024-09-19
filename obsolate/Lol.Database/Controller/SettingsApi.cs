using Lol.Database.Entites.Core;
using Lol.Database.Entites.Schema;

namespace Lol.Database.Controller
{
    public class SettingsApi : LolDbContext
    {
        #region GetSettingMenus

        public List<SettingMenus> GetSettingMenus()
        {
            var items = from s in Db.SettingMenus
                        select new SettingMenus()
                        {
                            Seq = s.Seq,
                            Category = s.Category,
                            Name = s.Name
                        };

            return items.ToList();
        }
        #endregion

        #region GetResolutions

        public List<Resolutions> GetResolutions()
        {
            var items = from s in Db.Resolutions
                        select new Resolutions()
                        {
                            Seq = s.Seq,
                            Name = s.Name
                        };

            return items.ToList();
        }
        #endregion
    }
}
