using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Collection.Local.ViewModels;

public class SpellsContentViewModel : ViewModelBase
{
    private readonly ISpellsDataLoader _spellsData;
    private List<Spell> _spells;
    private Spell _selectedSpell;

    public List<Spell> Spells
    {
        get => _spells;
        set => SetProperty(ref _spells, value);
    }

    public Spell SelectedSpell
    {
        get => _selectedSpell;
        set => SetProperty(ref _selectedSpell, value);
    }

    public SpellsContentViewModel(ISpellsDataLoader spellsData)
    {
        _spellsData = spellsData;
        LoadSpells();
    }

    private void LoadSpells()
    {
        List<Spell> spellsList = _spellsData.LoadSpells();
        Spells = spellsList;
        if (Spells.Any())
        {
            SelectedSpell = Spells.First();
        }
    }
}
