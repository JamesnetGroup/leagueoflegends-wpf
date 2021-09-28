using Lol.Data.History;
using System;
using System.Collections.Generic;

namespace Lol.ExampleData.History
{
    public partial class ExamHistory
    {
        static string imgResource(string folder, string name)
        {
            return $"/Lol.Resources;component/Images/{folder}/{name}.png";
        }

        // TODO: [Kevin] 필히 변경 해야함
        public static List<HistoryModel> GetHistory()
        {

            List<HistoryModel> source = new()
            {
                new HistoryModel
                {
                    Seq = 0,
                    Champion = imgResource("Square", "1"),
                    GameType = "개인/2인 랭크 게임",
                    MapType = "소환사의 협곡",
                    Result = "승리",
                    StDt = DateTime.Now,
                    GameTime = "25:13",
                    Money = 6633,
                    Cs = 30,
                    K = 0,
                    D = 8,
                    A = 4,
                    Level = 18,
                    Spell1 = imgResource("Spell", "6"),
                    Spell2 = imgResource("Spell", "7"),
                    Item1 = imgResource("Items", "doranring"),
                    Item2 = imgResource("Items", "zhonya"),
                    Item3 = imgResource("Items", "ionianshoes"),
                    Item4 = imgResource("Items", "rocketbelt"),
                    //Item5 = imgResource("Items", "warmog"),
                    Item6 = imgResource("Items", "rabadon"),
                    Item7 = imgResource("Items", "oraclelens"),
                },
                new HistoryModel
                {
                    Seq = 1,
                    Champion = imgResource("Square", "2"),
                    GameType = "개인/2인 랭크 게임",
                    MapType = "소환사의 협곡",
                    Result = "승리",
                    StDt = DateTime.Now,
                    GameTime = "21:13",
                    Money = 6633,
                    Cs = 30,
                    K = 3,
                    D = 1,
                    A = 6,
                    Level = 9,
                    Spell1 = imgResource("Spell", "ignite"),
                    Spell2 = imgResource("Spell", "7"),
                    Item1 = imgResource("Items", "potion2"),
                    Item2 = imgResource("Items", "trinityforce"),
                    Item3 = imgResource("Items", "thecollector"),
                    Item4 = imgResource("Items", "dominik"),
                    Item5 = imgResource("Items", "infinityedge"),
                    Item6 = imgResource("Items", "ionianshoes"),
                    Item7 = imgResource("Items", "ward"),
                },
                new HistoryModel
                {
                    Seq = 2,
                    Champion = imgResource("Square", "3"),
                    GameType = "개인/2인 랭크 게임",
                    MapType = "소환사의 협곡",
                    Result = "패배",
                    StDt = DateTime.Now,
                    GameTime = "24:13",
                    Money = 6633,
                    Cs = 30,
                    K = 12,
                    D = 0,
                    A = 5,
                    Level = 14,
                    Spell1 = imgResource("Spell", "ignite"),
                    Spell2 = imgResource("Spell", "7"),
                    Item1 = imgResource("Items", "potion"),
                    Item2 = imgResource("Items", "solari"),
                    Item4 = imgResource("Items", "shoes"),
                    Item5 = imgResource("Items", "targon"),
                    Item6 = imgResource("Items", "shurelya"),
                    Item7 = imgResource("Items", "oraclelens"),
                },
                new HistoryModel
                {
                    Seq = 3,
                    Champion = imgResource("Square", "4"),
                    GameType = "개인/2인 랭크 게임",
                    MapType = "소환사의 협곡",
                    Result = "패배",
                    StDt = DateTime.Now,
                    GameTime = "30:13",
                    Money = 6633,
                    Cs = 30,
                    K = 8,
                    D = 8,
                    A = 3,
                    Level = 7,
                    Spell1 = imgResource("Spell", "8"),
                    Spell2 = imgResource("Spell", "7"),
                    Item1 = imgResource("Items", "galeforce"),
                    Item2 = imgResource("Items", "thecollector"),
                    Item3 = imgResource("Items", "mortalreminder"),
                    Item4 = imgResource("Items", "platedshoes"),
                    Item5 = imgResource("Items", "cloak"),
                    Item7 = imgResource("Items", "oraclelens"),
                },
            };

            return source;
        }
    }
}
