using Lol.Data.History;
using System.Collections.Generic;

namespace Lol.ExampleData.History
{
    public partial class ExamHistory
    {
        public static List<HistoryModel> GetActivities()
        {
            List<HistoryModel> source = new()
            {
                new HistoryModel { ActivePercent = 10, Concept = imgResource("Concepts", "warrior"), Concept_Name = "전사" },
                new HistoryModel { ActivePercent = 55, Concept = imgResource("Concepts", "tanker"), Concept_Name = "탱커" },
                new HistoryModel { ActivePercent = 32, Concept = imgResource("Concepts", "wizard"), Concept_Name = "마법사" },
                new HistoryModel { ActivePercent = 64, Concept = imgResource("Concepts", "assassin"), Concept_Name = "암살자" },
                new HistoryModel { ActivePercent = 22, Concept = imgResource("Concepts", "support"), Concept_Name = "서포터" },
                new HistoryModel { ActivePercent = 11, Concept = imgResource("Concepts", "dealer"), Concept_Name = "원거리딜러" },
            };

            return source;
        }
    }
}
