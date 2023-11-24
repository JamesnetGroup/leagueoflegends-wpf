namespace Lol.Database.Entites.Schema
{
    public class FriendsHeader : IFriendsList
    {
        public bool IsExpanded { get; set; }
        public List<MyFriends> Children { get; set; }
        public string Header { get; set; }
        public Type Type => GetType();

        public FriendsHeader(string header, bool isExpanded)
        {
            Header = header;
            IsExpanded = isExpanded;
            Children = new List<MyFriends>();
        }
    }
}
