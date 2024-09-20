using Lol.Data.Enums;

namespace Lol.Data.Store
{
    public class FilterModel
    {
        public ItemType FilterType { get; set; }
        public ChampType? ChampionType { get; set; }
        public PackageType PriceType { get; set; }
        public string DisplayName { get; set; }
        public bool IsChecked { get; set; }

        public bool IsChampionVisible { get; }
        public bool IsEternalVisible { get; }
        public bool IsBundleVisible { get; }

        public FilterModel(ChampType type, string name, bool isChampion, bool isEternal, bool isBundle)
        {
            FilterType = ItemType.Champion;
            ChampionType = type;
            DisplayName = name;
            IsChampionVisible = isChampion;
            IsEternalVisible = isEternal;
            IsBundleVisible = isBundle;
        }

        public FilterModel(PackageType type, string name, bool isChampion, bool isEternal, bool isBundle)
        {
            FilterType = ItemType.Package;
            PriceType = type;
            DisplayName = name;
            IsChampionVisible = isChampion;
            IsEternalVisible = isEternal;
            IsBundleVisible = isBundle;
        }
    }
}
