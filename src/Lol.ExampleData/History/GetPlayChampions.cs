using Lol.Data.History;
using System.Collections.Generic;

namespace Lol.ExampleData.History
{
    public partial class ExamHistory
    {
        public static List<HistoryModel> GetPlayChampions()
        {
            List<HistoryModel> source = new()
            {
                new HistoryModel { Champion = ImgResource("Square", "1"), Percent = "19%" },
                new HistoryModel { Champion = ImgResource("Square", "2"), Percent = "14%" },
                new HistoryModel { Champion = ImgResource("Square", "3"), Percent = "15%" }
            };

            return source;
        }
    }
}
