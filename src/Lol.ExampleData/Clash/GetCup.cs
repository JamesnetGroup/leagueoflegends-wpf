using Lol.Data.Clash;
using System.Collections.Generic;

namespace Lol.ExampleData.Clash
{
	public partial class ExamClash
    {
        public static List<BaseModel> GetCup()
        {
            List<BaseModel> source = new()
            {
                new BaseModel(0, "밴들 시티 컵 4일 차"),
                new BaseModel(1, "밴들 시티 컵 3일 차"),
                new BaseModel(2, "밴들 시티 컵 2일 차"),
                new BaseModel(3, "밴들 시티 컵 1일 차"),
                new BaseModel(4, "타곤산 컵 4일 차"),
                new BaseModel(5, "타곤산 컵 3일 차"),
                new BaseModel(6, "타곤산 컵 2일 차"),
                new BaseModel(7, "타곤산 컵 1일 차"),
                new BaseModel(8, "빌지워터 컵 4일 차"),
                new BaseModel(9, "빌지워터 컵 3일 차"),
                new BaseModel(10, "빌지워터 컵 2일 차"),
                new BaseModel(11, "빌지워터 컵 1일 차"),
                new BaseModel(12, "MSI 컵 4일 차"),
                new BaseModel(13, "MSI 컵 3일 차"),
                new BaseModel(14, "MSI 컵 2일 차"),
                new BaseModel(15, "MSI 컵 1일 차")
            };

            return source;
        }
    }
}
