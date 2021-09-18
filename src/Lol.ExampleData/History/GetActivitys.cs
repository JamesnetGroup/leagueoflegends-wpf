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
                new HistoryModel { ActivePercent = 10, Job = "" },
                new HistoryModel { ActivePercent = 55, Job = "" },
                new HistoryModel { ActivePercent = 32, Job = "" },
                new HistoryModel { ActivePercent = 64, Job = "" },
                new HistoryModel { ActivePercent = 22, Job = "" }
            };

            return source;
        }
    }
}
