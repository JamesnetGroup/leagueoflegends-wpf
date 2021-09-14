using Lol.Data.Codes;
using System.Collections.Generic;

namespace Lol.ExampleData.Setting
{
    public partial class ExamSettings
    {
        public static List<WindowSizeCode> GetWinSizeList()
        {
            List<WindowSizeCode> source = new()
            {
                new WindowSizeCode { Name = "1024 x 576" },
                new WindowSizeCode { Name = "1280 x 720" },
                new WindowSizeCode { Name = "1600 x 900" },
                new WindowSizeCode { Name = "1920 x 1080" },
                new WindowSizeCode { Name = "2560 x 1440" }
            };
            return source;
        }
    }
}
