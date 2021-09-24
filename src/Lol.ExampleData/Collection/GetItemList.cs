using Lol.Data.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.ExampleData.Collection
{
    public partial class ExamItemList
    {
        static string imgResource(string folder, string name)
        {
            return $"/Lol.Resources;component/Images/{folder}/{name}.png";
        }

        public static List<ItemListModel> GetItemList()
        {
            List<ItemListModel> source = new()
            {
                new ItemListModel {
                    Seq = 0,
                    Name = "새로운 아이템 세트",
                    Champ = "모든 챔피언",
                    MapType1 = imgResource("Spell", "ignite"),
                    MapType2 = imgResource("Spell", "ignite"),
                    Option = imgResource("Spell", "ignite")
                },
                new ItemListModel
                {
                    Seq = 1,
                    Name = "새로운 아이템 세트(1)",
                    Champ = "모든 챔피언",
                    MapType1 = imgResource("Spell", "ignite"),
                    MapType2 = imgResource("Spell", "ignite"),
                    Option = imgResource("Spell", "ignite")
                },
                new ItemListModel
                {
                    Seq = 2,
                    Name = "새로운 아이템 세트(2)",
                    Champ = "모든 챔피언",
                    MapType1 = imgResource("Spell", "ignite"),
                    MapType2 = imgResource("Spell", "ignite"),
                    Option = imgResource("Spell", "ignite")
                },
                new ItemListModel
                {
                    Seq = 3,
                    Name = "새로운 아이템 세트(3)",
                    Champ = "모든 챔피언",
                    MapType1 = imgResource("Spell", "ignite"),
                    MapType2 = imgResource("Spell", "ignite"),
                    Option = imgResource("Spell", "ignite")
                },
                new ItemListModel
                {
                    Seq = 4,
                    Name = "새로운 아이템 세트(4)",
                    Champ = "모든 챔피언",
                    MapType1 = imgResource("Spell", "ignite"),
                    MapType2 = imgResource("Spell", "ignite"),
                    Option = imgResource("Spell", "ignite")
                }


            };
                
            return source;
            
        }
    }
}


