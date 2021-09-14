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

        public TierDetailModel(int seq, int parent_seq, string name, string sub_name, string time, string image_source)
        {
            Seq = seq;
            ParentSeq = parent_seq;
            Name = name;
            SubName = sub_name;
            Time = time;
            ImageSource = image_source;
        }
    }
}
