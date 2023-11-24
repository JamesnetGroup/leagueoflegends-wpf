namespace Lol.Data.Store
{
    public class SortingModel
    {
        public int Seq { get; set; }
        public string Name { get; set; }
        public string OrderBy { get; set; }

        public SortingModel(int seq, string name, string order)
        {
            Seq = seq;
            Name = name;
            OrderBy = order;
        }
    }
}
