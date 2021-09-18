using Lol.Data.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.ExampleData.History
{
    public partial class ExamHistory
    {
        public static List<HistoryModel> GetPlayChampions()
        {
            List<HistoryModel> source = new List<HistoryModel>();
            source.Add(new HistoryModel { Champion = imgResource("Square", "1"), Percent = "19%" });
            source.Add(new HistoryModel { Champion = imgResource("Square", "2"), Percent = "14%" });
            source.Add(new HistoryModel { Champion = imgResource("Square", "3"), Percent = "15%" });

            return source;
        }
    }
}
