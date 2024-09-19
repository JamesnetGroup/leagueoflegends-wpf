using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Collection.Local.Datas
{
    public class SkinsDataLoader : BaseResourceLoader<Skin, List<Skin>>, ISkinsDataLoader
    {
        protected override string AssemblyName => "Leagueoflegends.Support";
        protected override string ResourcePath => "Leagueoflegends.Support.Datas.Skins.yml";

        public List<Skin> LoadSkins() => LoadAndOrganize();

        public Dictionary<string, List<Skin>> GetSkinsGroupedByName()
        {
            var allSkins = LoadAndOrganize();
            return allSkins
                .GroupBy(s => s.Name)
                .ToDictionary(
                    g => g.Key,
                    g => g.OrderBy(s => s.ImageUrl).ToList()
                );
        }

        protected override IEnumerable<Skin> ConvertToItems(YamlData rawData)
        {
            return rawData.Select(item =>
            {
                return new Skin
                {
                    Name = item.GetValue<string>("name"),
                    SkinName = item.GetValue<string>("skinName"),
                    ImageUrl = $"/Leagueoflegends.Support;component/Images/Skins/{item.GetValue<string>("imageUrl")}",
                    IsPurchased = item.GetValue<bool>("isPurchased")
                };
            });
        }

        protected override List<Skin> OrganizeItems(IEnumerable<Skin> skins)
        {
            return skins.OrderBy(s => s.Name).ToList();
        }
    }
}
