using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;
namespace Leagueoflegends.Social.Local.Datas;

public class FriendDataLoader : BaseResourceLoader<Friend, List<FriendCategory>>, IFriendDataLoader
{
    protected override string AssemblyName => "Leagueoflegends.Support";
    protected override string ResourcePath => "Leagueoflegends.Support.Datas.Friends.yml";

    public List<FriendCategory> LoadFriends() => LoadAndOrganize();

    protected override IEnumerable<Friend> ConvertToItems(YamlData rawData)
    {
        return rawData.Select(item => new Friend
        {
            Seq = item.GetValue<int>("seq"),
            Name = item.GetValue<string>("name"),
            Status = item.GetValue<string>("status"),
            Category = item.GetValue<string>("category")
        });
    }

    protected override List<FriendCategory> OrganizeItems(IEnumerable<Friend> friends)
    {
        return friends.GroupBy(f => f.Category)
                      .Select(g => new FriendCategory { Name = g.Key, Children = g.ToList() })
                      .ToList();
    }
}
