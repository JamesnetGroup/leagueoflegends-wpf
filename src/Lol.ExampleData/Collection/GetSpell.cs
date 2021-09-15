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

            source.Add(new SpellModel { Name = "유체화", ImageSource = imgResource("speed") });
            source.Add(new SpellModel { Name = "회복", ImageSource = imgResource("heal") });
            source.Add(new SpellModel { Name = "방어막", ImageSource = imgResource("shield") });
            source.Add(new SpellModel { Name = "탈진", ImageSource = imgResource("exhaust") });
            source.Add(new SpellModel { Name = "점멸", ImageSource = imgResource("flash") });
            source.Add(new SpellModel { Name = "점화", ImageSource = imgResource("ignite") });

            return source;
        }
    }
}
