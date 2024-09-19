using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Store.Local.Datas;

public class StoreChampDataLoader : BaseResourceLoader<StoreChamp, List<StoreChamp>>, IStoreChampDataLoader
{
    protected override string AssemblyName => "Leagueoflegends.Support";
    protected override string ResourcePath => "Leagueoflegends.Support.Datas.StoreChamps.yml";

    public List<StoreChamp> LoadStoreChamps() => LoadAndOrganize();

    protected override IEnumerable<StoreChamp> ConvertToItems(YamlData rawData)
    {
        return rawData.Select(item => new StoreChamp
        {
            Seq = item.GetValue<int>("seq"),
            Name = item.GetValue<string>("name"),
            Image = item.GetValue<string>("image"),
            RP = item.GetValue<int>("rp"),
            BE = item.GetValue<int>("be"),
            IsLocked = item.GetValue<bool>("isLocked"),
            ImageUrl = $"/Leagueoflegends.Support;component/Images/Stores/{item.GetValue<string>("image")}.png"
        });
    }

    protected override List<StoreChamp> OrganizeItems(IEnumerable<StoreChamp> storeChamps)
    {
        return storeChamps.OrderBy(c => c.Seq).ToList();
    }
}
