using Jamesnet.Foundation;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Collection.Local.Datas;

public class SpellsDataLoader : BaseResourceLoader<Spell, List<Spell>>, ISpellsDataLoader
{
    protected override string AssemblyName => "Leagueoflegends.Support";
    protected override string ResourcePath => "Leagueoflegends.Support.Datas.Spells.yml";

    public List<Spell> LoadSpells() => LoadAndOrganize();

    protected override IEnumerable<Spell> ConvertToItems(YamlData rawData)
    {
        return rawData.Select(item =>
        {
            var typesString = item.GetValue<string>("types");
            var typesList = typesString.Split(';').ToList();
            var typesCommaSeparated = string.Join(", ", typesList);

            return new Spell
            {
                Seq = item.GetValue<int>("seq"),
                Name = item.GetValue<string>("name"),
                DisplayName = item.GetValue<string>("displayName"),
                Level = item.GetValue<int>("level"),
                Types = typesList,
                TypesString = typesCommaSeparated,
                Content = item.GetValue<string>("content"),
                Delay = item.GetValue<int>("delay"),
                ImageUrl = $"/Leagueoflegends.Support;component/Images/spell_{item.GetValue<string>("name").ToLower()}.png"
            };
        });
    }

    protected override List<Spell> OrganizeItems(IEnumerable<Spell> spells)
    {
        return spells.OrderBy(s => s.Seq).ToList();
    }
}
