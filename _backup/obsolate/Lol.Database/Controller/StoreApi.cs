using Lol.Database.Common;
using Lol.Database.Entites.Core;
using Lol.Database.Entites.Schema;

namespace Lol.Database.Controller
{
    // TODO: [Kevin] StoreItems 데이터 병합 작업 예정
    public class StoreApi : LolDbContext
    {
        #region GetCategory

        //TODO: [Kevin] Store Category merge > 조회시 임시 TypeSeq 인자 넘김
        public List<StoreDetails> GetCategory(int type_seq)
        {
            var query = from s in Db.StoreDetails.Where(x => x.TypeSeq == type_seq)
                        select new StoreDetails
                        {
                            Seq = s.Seq,
                            TypeSeq = s.TypeSeq,
                            Name = s.Name,
                        };
            return query.ToList();
        }
        #endregion

        #region GetSorting

        public List<StoreChampSortings> GetSorting(string id)
        {
            var query = from s in Db.StoreChampSortings
                        where s.Id == id
                        select new StoreChampSortings
                        {
                            Seq = s.Seq,
                            Id = s.Id,
                            Name = s.Name,
                            Option = s.Option
                        };
            return query.ToList();
        }
        #endregion

        #region GetChamps

        public List<StoreItems> GetChamps()
        {
            var query = from s in Db.StoreChamps
                        select new StoreItems
                        {
                            Seq = s.Seq,
                            Name = s.Name,
                            ImgSource = ResourceHelper.ImgResource(s.ImgSource),
                            RP = s.RP,
                            BE = s.BE,
                        };
            return query.ToList();
        }
        #endregion

        #region GetNewSkins

        public List<NewSkins> GetNewSkins()
        {
            var query = from s in Db.NewSkins
                        select new NewSkins
                        {
                            Seq = s.Seq,
                            SkinValue = s.SkinValue,
                            Name = s.Name,
                            ImgSource = ResourceHelper.ImgResource(s.ImgSource),
                            Content = s.Content,
                        };

            return query.ToList();
        }
        #endregion

        #region GetSkinSets

        public List<SkinSets> GetSkinSets()
        {
            var query = from s in Db.SkinSets
                        select new SkinSets
                        {
                            Seq = s.Seq,
                            Name = s.Name,
                            ImgSource = ResourceHelper.ImgResource(s.ImgSource),
                            Value = s.Value,
                        };

            return query.ToList();
        }
        #endregion

        #region GetPopularities

        public List<Popularities> GetPopularities()
        {
            Db.PopularityDetails.ForEach(x => {
                x.ImgSource = ResourceHelper.ImgResource(x.ImgSource);
            });

            var query = from s in Db.Popularities
                        select new Popularities
                        {
                            Seq = s.Seq,
                            Header = s.Header,
                            Details = Db.PopularityDetails.Where(x => x.ParentSeq == s.Seq).ToList(),
                        };

            return query.ToList();
        }
        #endregion

        #region GetSkins

        public List<StoreItems> GetSkins()
        {
            var query = from s in Db.StoreSkins
                        select new StoreItems
                        {
                            Seq = s.Seq,
                            Name = s.Name,
                            ImgSource = ResourceHelper.ImgResource(s.ImgSource),
                            RP = s.RP,
                            BE = s.BE,
                        };
            return query.ToList();
        }
        #endregion

        #region GetTFTs

        public List<StoreItems> GetTFTs()
        {
            var query = from s in Db.StoreTFTs
                        select new StoreItems
                        {
                            Seq = s.Seq,
                            Name = s.Name,
                            ImgSource = ResourceHelper.ImgResource(s.ImgSource),
                            RP = s.RP,
                            BE = s.BE,
                        };
            return query.ToList();
        }
        #endregion

        #region GetLoots

        public List<StoreItems> GetLoots()
        {
            var query = from s in Db.StoreLoots
                        select new StoreItems
                        {
                            Seq = s.Seq,
                            Name = s.Name,
                            ImgSource = ResourceHelper.ImgResource(s.ImgSource),
                            RP = s.RP,
                            BE = s.BE,
                        };
            return query.ToList();
        }
        #endregion

        #region GetEtcItems

        public List<StoreItems> GetEtcItems()
        {
            var query = from s in Db.StoreEtcItems
                        select new StoreItems
                        {
                            Seq = s.Seq,
                            Name = s.Name,
                            ImgSource = ResourceHelper.ImgResource(s.ImgSource),
                            RP = s.RP,
                            BE = s.BE,
                        };
            return query.ToList();
        }
        #endregion

    }
}
