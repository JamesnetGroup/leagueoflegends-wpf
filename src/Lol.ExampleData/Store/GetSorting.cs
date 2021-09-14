using Lol.Data.Store;
using System.Collections.Generic;

namespace Lol.ExampleData.Store
{
    public partial class ExamStore
    {
        public static List<SortingModel> GetSorting(string name)
        {
            List<SortingModel> source = new();

            if (name != "BUNDLES")
            {
                source.Add(new SortingModel(0, "Release Date", "Down"));
                source.Add(new SortingModel(1, "Release Date", "Up"));
                source.Add(new SortingModel(2, "Price (RP)", "Down"));
                source.Add(new SortingModel(3, "Price (RP)", "Up"));
                source.Add(new SortingModel(4, "Price (BE)", "Down"));
                source.Add(new SortingModel(5, "가격 (BE)", "Up"));
                source.Add(new SortingModel(6, "Alphabetical", "Down"));
                source.Add(new SortingModel(7, "Alphabetical", "Up"));
            }
            else
            {
                source.Add(new SortingModel(0, "Release Date", "Down"));
                source.Add(new SortingModel(1, "Release Date", "Up"));
                source.Add(new SortingModel(2, "Price (RP)", "Down"));
                source.Add(new SortingModel(3, "Price (RP)", "Up"));
                source.Add(new SortingModel(4, "Alphabetical", "Down"));
                source.Add(new SortingModel(5, "Alphabetical", "Up"));
            }

            return source;
        }
    }
}
