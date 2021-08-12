using Leagueoflegends.Data.Store;
using System.Collections.Generic;

namespace Leagueoflegends.ExampleData.Store
{
    public partial class ExamStore
    {
        public static List<SortingModel> GetSorting(string name)
        {
            List<SortingModel> source = new();

            if (name != "Bundles")
            {
                source.Add(new SortingModel(0, "출시 일자", "Down"));
                source.Add(new SortingModel(1, "출시 일자", "Up"));
                source.Add(new SortingModel(2, "가격 (RP)", "Down"));
                source.Add(new SortingModel(3, "가격 (RP)", "Up"));
                source.Add(new SortingModel(4, "가격 (BE)", "Down"));
                source.Add(new SortingModel(5, "가격 (BE)", "Up"));
                source.Add(new SortingModel(6, "가나다순", "Down"));
                source.Add(new SortingModel(7, "가나다순", "Up"));
            }
            else
            {
                source.Add(new SortingModel(0, "출시 일자", "Down"));
                source.Add(new SortingModel(1, "출시 일자", "Up"));
                source.Add(new SortingModel(2, "가격 (RP)", "Down"));
                source.Add(new SortingModel(3, "가격 (RP)", "Up"));
                source.Add(new SortingModel(4, "가나다순", "Down"));
                source.Add(new SortingModel(5, "가나다순", "Up"));
            }

            return source;
        }
    }
}
