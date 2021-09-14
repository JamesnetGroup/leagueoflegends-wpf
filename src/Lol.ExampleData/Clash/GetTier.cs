using Lol.Data.Clash;
using System.Collections.Generic;

namespace Lol.ExampleData.Clash
{
    public partial class ExamClash
    {
        public static List<BaseModel> GetTier()
        {
            List<BaseModel> source = new()
            {
                new BaseModel(0, "Ⅰ"),
                new BaseModel(1, "Ⅱ"),
                new BaseModel(2, "Ⅲ"),
                new BaseModel(3, "Ⅳ")
            };

            return source;
        }
    }
}
