using Leagueoflegends.Data.Enums;
using Leagueoflegends.Data.Store;
using System.Collections.Generic;
using System.Linq;

namespace Leagueoflegends.ExampleData.Store
{
    public partial class ExamStore
    {
        public static List<FilterModel> filters = new()
        {
            new FilterModel(ChampType.Assassin, "Assassin", true, true, false),
            new FilterModel(ChampType.Fighter, "Fighter", true, true, false),
            new FilterModel(ChampType.Mage, "Mage", true, true, false),
            new FilterModel(ChampType.Marksman, "Marksman", true, true, false),
            new FilterModel(ChampType.Support, "Support", true, true, false),
            new FilterModel(ChampType.Tanker, "Tanker", true, true, false),
            new FilterModel(PackageType.StarterSet, "입문자 세트", false, true, false),
            new FilterModel(PackageType.SeriesA, "시리즈1", false, true, false),
            new FilterModel(PackageType.OnSale, "할인 중", true, true, false),
            new FilterModel(PackageType.Limited, "한정 판매", false, false, true)
        };

        public static List<FilterModel> GetFilters(string name)
        {
            List<FilterModel> source = new();

            switch (name)
            {
                case "Champions": source = filters.Where(x => x.IsChampionVisible).ToList(); break;
                case "Eternals": source = filters.Where(x => x.IsEternalVisible).ToList(); break;
                case "Bundles": source = filters.Where(x => x.IsBundleVisible).ToList(); break;
            }

            return source;
        }
    }
}
