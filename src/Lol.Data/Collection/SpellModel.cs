using System.Collections.Generic;
using System.Linq;

namespace Lol.Data.Collection
{
    public class SpellModel
    {
        public int Seq { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public List<GamePlayModel> PlayTypes { get; set; }
        public string Content { get; set; }
        public int Delay { get; set; }
        public string DisplayName => string.Join(", ", PlayTypes.Select(x => x.Name.ToString()).ToArray());
    }

    public class GamePlayModel
    {
        public int Seq { get; set; }
        public string Name { get; set; }

        public GamePlayModel(int seq)
        {
            Seq = seq;
            Name = seq switch
            {
                0 => "무작위 총력전",
                1 => "클래식",
                2 => "튜토리얼",
                _ => throw new System.NotImplementedException(),
            };
        }
    }
}
