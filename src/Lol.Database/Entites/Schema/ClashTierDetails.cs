namespace Lol.Database.Entites.Schema
{
    public class ClashTierDetails
    {
        public int Seq { get; set; }
        public int ParentSeq { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string SubName { get; set; }
        public string Time { get; set; }

        public string ImageSource => $"/Lol.Resources;component/Images/WinIcons/{Id}.png";
    }
}
