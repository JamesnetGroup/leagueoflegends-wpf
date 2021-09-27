namespace Lol.Data.Clash
{
    public class TierDetailModel
    {
        public int Seq { get; set; }
        public int ParentSeq { get; set; }
        public string Name { get; set; }
        public string SubName { get; set; }
        public string Time { get; set; }
        public string ImageSource { get; set; }

        public TierDetailModel(int seq, int parentSeq, string name, string subName, string time, string imageSource)
        {
            Seq = seq;
            ParentSeq = parentSeq;
            Name = name;
            SubName = subName;
            Time = time;
            ImageSource = imageSource;
        }
    }
}
