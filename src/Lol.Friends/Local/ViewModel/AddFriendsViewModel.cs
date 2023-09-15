using System.Windows.Input;
using Lol.Friends.Local.Collection;
using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using DevNcore.UI.Foundation.Mvvm;
using Lol.Support.Local.Helpers;
using Jamesnet.Wpf.Mvvm;

namespace Lol.Friends.Local.ViewModel
{
    public class AddFriendsViewModel : ObservableBase
    {
        private string _keyword;

        public ICommand CompleteCommand { get; set; }
        public ICommand KeywordCommand { get; private set; }
        public ICommand CloseKeywordCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }
        public ICommand RequestCommand { get; private set; }

        public string Keyword
        {
            get { return _keyword; }
            set { _keyword = value; OnPropertyChanged(); }
        }

        public FriendsCollection UserCollection { get; }

        public AddFriendsViewModel(MenuService menuService)
        {
            UserCollection = new();

            Keyword = "";
            KeywordCommand = new RelayCommand<object>(KeywordChanged);
            CloseKeywordCommand = new RelayCommand<object>(CloseKeyword);
            CompleteCommand = new RelayCommand<object>((o) => menuService.CloseModal());
            DeleteCommand = new RelayCommand<RequestUsers>(UserCollection.CancelRequest);
            RequestCommand = new RelayCommand<RequestUsers>(UserCollection.SendRequest);

            var data = new FriendsApi().GetFriendRequests(0);
            UserCollection.AddRange(data);
        }

        private void KeywordChanged(object obj)
        {
            Keyword = (obj as RiotTextBox).Text;
        }

        private void CloseKeyword(object obj)
        {
            Keyword = "";
        }
    }
}
