namespace Lol.Database.Entites.Schema
{
    public class GameRooms
    {
        public int Seq { get; set; }
        public string MapName { get; set; }
        public string WarType { get; set; }
        public string Content { get; set; }
        public List<GameType> GameTypes { get; set; }
    }

    public class GameType
    {
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
