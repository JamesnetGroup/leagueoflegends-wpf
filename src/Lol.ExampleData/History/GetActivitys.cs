using Lol.Data.History;
using System.Collections.Generic;

namespace Lol.ExampleData.History
{
    public partial class ExamHistory
    {
        public static string ImgResource(string folder, string name)
        {
            return $"/Lol.Resources;component/Images/{folder}/{name}.png";
        }

        public static List<HistoryModel> GetActivities()
        {
            List<HistoryModel> source = new()
            {
                new HistoryModel { ActivePercent = 10, Concept = ImgResource("Concepts", "warrior"), ConceptName = "전사" },
                new HistoryModel { ActivePercent = 55, Concept = ImgResource("Concepts", "tanker"), ConceptName = "탱커" },
                new HistoryModel { ActivePercent = 32, Concept = ImgResource("Concepts", "wizard"), ConceptName = "마법사" },
                new HistoryModel { ActivePercent = 64, Concept = ImgResource("Concepts", "assassin"), ConceptName = "암살자" },
                new HistoryModel { ActivePercent = 22, Concept = ImgResource("Concepts", "support"), ConceptName = "서포터" },
                new HistoryModel { ActivePercent = 11, Concept = ImgResource("Concepts", "dealer"), ConceptName = "원거리딜러" },
            };

            return source;
        }
    }
}
