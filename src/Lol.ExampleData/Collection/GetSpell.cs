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

            source.Add(new SpellModel { Name = "유체화", ImageSource = imgResource("haste") });
            source.Add(new SpellModel { Name = "회복", ImageSource = imgResource("heal") });
            source.Add(new SpellModel { Name = "방어막", ImageSource = imgResource("barrier") });
            source.Add(new SpellModel { Name = "탈진", ImageSource = imgResource("exhaust") });
            source.Add(new SpellModel { Name = "총명", ImageSource = imgResource("mana") });
            source.Add(new SpellModel { Name = "표식", ImageSource = imgResource("snowball") });
            source.Add(new SpellModel { Name = "순간이동", ImageSource = imgResource("teleport") });
            source.Add(new SpellModel { Name = "점멸", ImageSource = imgResource("flash") });
            source.Add(new SpellModel { Name = "강타", ImageSource = imgResource("smite") });
            source.Add(new SpellModel { Name = "점화", ImageSource = imgResource("dot") });
            source.Add(new SpellModel { Name = "정화", ImageSource = imgResource("boost") });

            return source;
        }
    }
}
