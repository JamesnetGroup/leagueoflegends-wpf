using Lol.Data.GameRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.ExampleData.GameRoom
{
    public partial class ExamGameRoom
    {
        public static List<GameRoomModel> GetGameRoom()
        {
            List<GameRoomModel> source = new()
            {
                new GameRoomModel
                {
                    Seq = 0,
                    MapName = "소환사의 협곡",
                    WarType = "5대5",
                    Content = "공격로에서 상대를 격파하고 5:5 팀 전투에 뛰어들어 적 넥서스를 파괴해 보세요.",
                    GameTypes = new()
                    {
                        new GameType
                        {
                            Name = "비공개 선택"
                        },
                        new GameType
                        {
                            Name = "개인/2인 랭크 게임"
                        },
                        new GameType
                        {
                            Name = "자유 랭크 게임",
                            Content = "4인 파티로는 참여가 불가능합니다."
                        },
                    }
                },
                new GameRoomModel
                {
                    Seq = 1,
                    MapName = "무작위 총력전",
                    WarType = "5대5",
                    Content = "공격로에서 상대를 격파하고 5:5 팀 전투에 뛰어들어 적 넥서스를 파괴해 보세요.",
                    GameTypes = new()
                    {
                        new GameType
                        {
                            Name = "비공개 선택"
                        },
                        new GameType
                        {
                            Name = "개인/2인 랭크 게임"
                        },
                        new GameType
                        {
                            Name = "자유 랭크 게임",
                            Content = "4인 파티로는 참여가 불가능합니다."
                        },
                    }
                },
                new GameRoomModel
                {
                    Seq = 2,
                    MapName = "전력적 팀 전투",
                    WarType = "난투전",
                    Content = "공격로에서 상대를 격파하고 5:5 팀 전투에 뛰어들어 적 넥서스를 파괴해 보세요.",
                    GameTypes = new()
                    {
                        new GameType
                        {
                            Name = "비공개 선택"
                        },
                        new GameType
                        {
                            Name = "개인/2인 랭크 게임"
                        },
                        new GameType
                        {
                            Name = "자유 랭크 게임",
                            Content = "4인 파티로는 참여가 불가능합니다."
                        },
                    }
                },
                new GameRoomModel
                {
                    Seq = 3,
                    MapName = "U.R.F",
                    WarType = "5대5",
                    Content = "공격로에서 상대를 격파하고 5:5 팀 전투에 뛰어들어 적 넥서스를 파괴해 보세요.",
                    GameTypes = new()
                    {
                        new GameType
                        {
                            Name = "비공개 선택"
                        },
                        new GameType
                        {
                            Name = "개인/2인 랭크 게임"
                        },
                        new GameType
                        {
                            Name = "자유 랭크 게임",
                            Content = "4인 파티로는 참여가 불가능합니다."
                        },
                    }
                },
            };

            return source;
        }
    }
}
