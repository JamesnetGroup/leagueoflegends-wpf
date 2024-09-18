using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.Local.Datas;

public interface ISpellsDataLoader
{
    List<Spell> LoadSpells();
}
