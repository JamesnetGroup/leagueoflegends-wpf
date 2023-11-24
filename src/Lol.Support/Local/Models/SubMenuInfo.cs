namespace Lol.Support.Local.Models
{
    public class SubMenuInfo
    {
        public int Seq { get; set; }
        public int MainSeq { get; set; }
        public string Name { get; set; }
        public string ContentName { get; }

        public SubMenuInfo(int seq, int mainSeq, string name, string contentName = "")
        {
            Seq = seq;
            MainSeq = mainSeq;
            Name = name;
            ContentName = contentName;
        }
    }
}
