using Lol.Data.WinningTeam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.ExampleData.WinningTeam
{
    public partial class ExamWinningTeam
    {
        public static List<CupModel> GetCup()
        {
            List<CupModel> source = new()
            {
                new CupModel(0, "밴들 시티 컵 4일 차"),
                new CupModel(1, "밴들 시티 컵 3일 차"),
                new CupModel(2, "밴들 시티 컵 2일 차"),
                new CupModel(3, "밴들 시티 컵 1일 차"),
                new CupModel(4, "타곤산 컵 4일 차"),
                new CupModel(5, "타곤산 컵 3일 차"),
                new CupModel(6, "타곤산 컵 2일 차"),
                new CupModel(7, "타곤산 컵 1일 차"),
                new CupModel(8, "빌지워터 컵 4일 차"),
                new CupModel(9, "빌지워터 컵 3일 차"),
                new CupModel(10, "빌지워터 컵 2일 차"),
                new CupModel(11, "빌지워터 컵 1일 차"),
                new CupModel(12, "MSI 컵 4일 차"),
                new CupModel(13, "MSI 컵 3일 차"),
                new CupModel(14, "MSI 컵 2일 차"),
                new CupModel(15, "MSI 컵 1일 차"),

            };

            return source;
        }
    }
}
