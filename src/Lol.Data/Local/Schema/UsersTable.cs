namespace Lol.Data.Local.Schema
{
    public class UsersTable
    {
        public int Seq { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Status { get; set; }
        public int Avatar { get; set; }
        public string Nation { get; set; }

        public UsersTable()
        {
            Level = RandomHelper.Random.Next(7, 300);
            Nation = "KR";
            Avatar = RandomHelper.Random.Next(0, 42);
        }
    }
}
