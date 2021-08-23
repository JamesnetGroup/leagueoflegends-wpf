namespace Lol.Data.Clash
{
    public class CategoryModel
    {
        public int Seq { get; set; }
        public string Name { get; set; }

        public CategoryModel(int seq, string name)
        {
            Seq = seq;
            Name = name;
        }
    }
}
