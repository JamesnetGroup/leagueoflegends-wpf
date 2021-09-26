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
                    Content = "얻어붙은 땅, 좁은 다리 위에서 무작위 챔피언 5:5 팀 전투가 벌어집니다. 모든것을 파괴하며 상대 진영으로 진격해 보세요.",
                    GameTypes = new()
                    {
                        new GameType
                        {
                            Name = "무작위 총력전"
                        }
                    }
                },
                new GameRoomModel
                {
                    Seq = 2,
                    MapName = "전력적 팀 전투",
                    WarType = "난투전",
                    Content = "챔피언들로 전략적인 팀을 구성해 결투장으로 진격시키세요. 총 7명의 상대와 겨루오 끝까지 살아남아야 합니다.",
                    GameTypes = new()
                    {
                        new GameType
                        {
                            Name = "일반"
                        },
                        new GameType
                        {
                            Name = "랭크"
                        },
                        new GameType
                        {
                            Name = "초고속 모드",
                        },
                    }
                },
                new GameRoomModel
                {
                    Seq = 3,
                    MapName = "U.R.F",
                    WarType = "5대5",
                    Content = "U.R.F 모드에서 쉴 새 없이 스킬을 난사해 보세요.",
                    GameTypes = new()
                    {
                        new GameType
                        {
                            Name = "U.R.F"
                        }
                    }
                },
            };

            return source;
        }
    }
}
