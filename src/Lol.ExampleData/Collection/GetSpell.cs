using Lol.Data.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.ExampleData.Collection
{
    public partial class ExamSpell
    {
        static string imgResource(string name)
        {
            return $"/Lol.Resources;component/Images/Spell/{name}.jpg";
        }

        public static List<SpellModel> GetSpell()
        {
            var source = new List<SpellModel>();

            source.Add(new SpellModel {Name = "점화", ImageSource = imgResource("ignite") });
            source.Add(new SpellModel {Name = "점멸", ImageSource = imgResource("flash") });

            return source;
        }
    }
}
