using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;
namespace Leagueoflegends.Social.Local.ViewModels;

public class SocialContentViewModel : ViewModelBase
{
    private readonly IFriendDataLoader _friendsData;
    private List<FriendCategory> _friends;

    public List<FriendCategory> Friends
    {
        get => _friends;
        set => SetProperty(ref _friends, value);
    }

    public SocialContentViewModel(IFriendDataLoader friendsData)
    {
        _friendsData = friendsData;
        LoadFriends();
    }

    private void LoadFriends()
    {
        Friends = _friendsData.LoadFriends();
    }
}
