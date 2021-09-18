using Lol.Data.Collection;
using System.Collections.Generic;

namespace Lol.ExampleData.Collection
{
    public partial class ExamSpell
    {
        static string imgResource(string name)
        {
            return $"/Lol.Resources;component/Images/Spell/{name}.png";
        }

        public static List<SpellModel> GetSpell()
        {
            var source = new List<SpellModel>();

            source.Add(new SpellModel { Name = "유체화", ImageSource = imgResource("haste"), SpellName = "유체화", Level = "소환사 레벨 1" });
            source.Add(new SpellModel { Name = "회복", ImageSource = imgResource("heal"), SpellName = "회복", Level = "소환사 레벨 1" });
            source.Add(new SpellModel { Name = "방어막", ImageSource = imgResource("barrier"), SpellName = "방어막", Level = "소환사 레벨 4" });
            source.Add(new SpellModel { Name = "탈진", ImageSource = imgResource("exhaust"), SpellName = "탈진", Level = "소환사 레벨 4" });
            source.Add(new SpellModel { Name = "총명", ImageSource = imgResource("mana"), SpellName = "총명", Level = "소환사 레벨 6" });
            source.Add(new SpellModel { Name = "표식", ImageSource = imgResource("snowball"), SpellName = "표식", Level = "소환사 레벨 6" });
            source.Add(new SpellModel { Name = "순간이동", ImageSource = imgResource("teleport"), SpellName = "순간이동", Level = "소환사 레벨 7" });
            source.Add(new SpellModel { Name = "점멸", ImageSource = imgResource("flash"), SpellName = "점멸", Level = "소환사 레벨 7" });
            source.Add(new SpellModel { Name = "강타", ImageSource = imgResource("smite"), SpellName = "강타", Level = "소환사 레벨 9" });
            source.Add(new SpellModel { Name = "점화", ImageSource = imgResource("dot"), SpellName = "점화", Level = "소환사 레벨 9" });
            source.Add(new SpellModel { Name = "정화", ImageSource = imgResource("boost"), SpellName = "정화", Level = "소환사 레벨 9" });

            return source;
        }
    }
}
