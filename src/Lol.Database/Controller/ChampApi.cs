using Lol.Database.Common;
using Lol.Database.Entites.Core;
using Lol.Database.Entites.Schema;

namespace Lol.Database.Controller
{
    public class ChampApi : LolDbContext
    {
        #region GetChampFilter1

        public List<ChampFilter> GetChampFilter1()
        {
            var query = from c in Db.ChampFilter
                        where c.Type == 0
                        select new ChampFilter
                        {
                            Seq = c.Seq,
                            Content = c.Content,
                            Type = c.Type
                        };
            return query.ToList();
        }
        #endregion

        #region GetChampFilter2

        public List<ChampFilter> GetChampFilter2()
        {
            var query = from c in Db.ChampFilter
                        where c.Type == 1
                        select new ChampFilter
                        {
                            Seq = c.Seq,
                            Content = c.Content,
                            Type = c.Type
                        };
            return query.ToList();
        }
        #endregion

        public List<Champions> GetChampData()
        {
            Db.Champions.ForEach(x => {
                x.Img = ResourceHelper.ImgResource(x.Img);
                x.Insignia = ResourceHelper.ImgResource(x.Insignia);
            });

            var query = from c in Db.Champions
                        select new Champions
                        {
                            Seq = c.Seq,
                            Champ = c.Champ,
                            Name = c.Name,
                            HeaderSeq = c.HeaderSeq,
                            Eternals = c.Eternals
                        };

            return query.ToList();
        }

        public List<ChampTreeItem> GetChampTreeItem()
        {
            Db.Champions.ForEach(x => {
                x.Img = ResourceHelper.ImgResource(x.Img);
                x.Insignia = ResourceHelper.ImgResource(x.Insignia);
            });

            var query = from c in Db.ChampTreeItem
                        select new ChampTreeItem 
                        {
                            Seq = c.Seq,
                            Role = c.Role,
                            Children = Db.Champions.Where(x => x.HeaderSeq == c.Seq).OrderBy(y => y.Name).ToList(),
                            Header = c.Header,
                            IsExpanded =  c.IsExpanded
                        };
            return query.ToList();
        }

        public List<ChampTreeItem> GetChampTreeItem(string value)
        {
            Db.Champions.ForEach(x => {
                x.Img = ResourceHelper.ImgResource(x.Img);
                x.Insignia = ResourceHelper.ImgResource(x.Insignia);
            });

            var query = from c in Db.ChampTreeItem
                        select new ChampTreeItem
                        {
                            Seq = c.Seq,
                            Role = c.Role,
                            Children = Db.Champions.Where(x => x.HeaderSeq == c.Seq && x.Name.Contains(value)).OrderBy(y => y.Name).ToList(),
                            Header = c.Header,
                            IsExpanded = c.IsExpanded
                        };
            return query.ToList();
        }
    }
}
