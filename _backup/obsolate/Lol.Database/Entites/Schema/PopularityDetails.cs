namespace Lol.Database.Entites.Schema
{
    public class PopularityDetails
    {
        public int Seq { get; set; }
        public int ParentSeq { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public string ImgSource { get; set; }
        public double Discount { get; set; }
    }
}
