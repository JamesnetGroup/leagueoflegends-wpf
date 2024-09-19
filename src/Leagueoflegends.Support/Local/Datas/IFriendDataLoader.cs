using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.Local.Datas;
public interface IFriendDataLoader
{
    List<FriendCategory> LoadFriends();
}
