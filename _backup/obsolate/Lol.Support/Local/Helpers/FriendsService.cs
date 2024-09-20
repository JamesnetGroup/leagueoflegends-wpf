namespace Lol.Support.Local.Helpers
{
    public class FriendsService
    {
        private object _friends;

        public void SetFriends(object friends)
        {
            _friends = friends;
        }

        public object GetFriends()
        {
            return _friends;
        }
    }
}
