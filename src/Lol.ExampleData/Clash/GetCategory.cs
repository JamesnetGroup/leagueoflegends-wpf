using Lol.Data.Clash;
using System.Collections.Generic;

namespace Lol.ExampleData.Clash
{
    public partial class ExamClash
    {
        public static List<CategoryModel> GetCategory()
        {
            List<CategoryModel> source = new()
            {
                new CategoryModel(0, "일정"),
                new CategoryModel(1, "전적")
            };

            return source;
        }
    }
}
