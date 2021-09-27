using Lol.Data.Enums;
using Lol.Data.Store;
using System.Collections.Generic;
using System.Linq;

namespace Lol.ExampleData.Store
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
            new FilterModel(ChampType.Tanker, "Tank", true, true, false),
            new FilterModel(PackageType.StarterSet, "Starter Series", false, true, false),
            new FilterModel(PackageType.SeriesA, "Series 1", false, true, false),
            new FilterModel(PackageType.OnSale, "On Sale", true, true, false),
            new FilterModel(PackageType.Limited, "Limited Availability", false, false, true)
        };

        public static List<FilterModel> GetFilters(string name)
        {
            List<FilterModel> source = new();

            switch (name)
            {
                case "CHAMPIONS": source = filters.Where(x => x.IsChampionVisible).ToList(); break;
                case "ETERNALS": source = filters.Where(x => x.IsEternalVisible).ToList(); break;
                case "BUNDLES": source = filters.Where(x => x.IsBundleVisible).ToList(); break;
                default:
                    break;
            }

            return source;
        }
    }
}
