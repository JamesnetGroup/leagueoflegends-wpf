using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Collection.Local.Datas;

public class OptionDataLoader : BaseResourceLoader<Option, List<Option>>, IOptionDataLoader
{
    protected override string AssemblyName => "Leagueoflegends.Support";
    protected override string ResourcePath => "Leagueoflegends.Support.Datas.Options.yml";

    public List<Option> LoadOptions() => LoadAndOrganize();

    public List<Option> GetByCategory(string category)
    {
        return LoadOptions().Where(x => x.Category == category).ToList();
    }

    protected override IEnumerable<Option> ConvertToItems(YamlData rawData)
    {
        return rawData.Select(item => new Option
        {
            Category = item.GetValue<string>("category"),
            Name = item.GetValue<string>("name"),
            IsSelected = item.GetValue<bool>("isSelected")
        });
    }

    protected override List<Option> OrganizeItems(IEnumerable<Option> options)
    {
        return options.ToList();
    }
}
