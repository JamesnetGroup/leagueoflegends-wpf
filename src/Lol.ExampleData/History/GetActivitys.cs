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
                new HistoryModel { ActivePercent = 10, Concept = imgResource("Concepts", "warrior") },
                new HistoryModel { ActivePercent = 55, Concept = imgResource("Concepts", "tanker") },
                new HistoryModel { ActivePercent = 32, Concept = imgResource("Concepts", "wizard") },
                new HistoryModel { ActivePercent = 64, Concept = imgResource("Concepts", "assassin") },
                new HistoryModel { ActivePercent = 22, Concept = imgResource("Concepts", "support") },
                new HistoryModel { ActivePercent = 11, Concept = imgResource("Concepts", "dealer") },
            };

            return source;
        }
    }
}
