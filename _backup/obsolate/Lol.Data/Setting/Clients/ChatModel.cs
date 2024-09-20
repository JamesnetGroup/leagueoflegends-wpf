namespace Lol.Data.Setting.Clients
{
    public class ChatModel
    {
        public bool SlangFilter { get; set; } = true;
        public bool LinkCaution { get; set; } = true;
        public bool MoreMenuVisible { get; set; } = true;
        public bool NewFriends { get; set; } = true;

        public ChatModel()
        {
        }
    }
}
