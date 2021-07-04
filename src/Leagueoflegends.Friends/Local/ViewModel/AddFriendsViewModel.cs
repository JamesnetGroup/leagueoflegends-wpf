using Leagueoflegends.Data.Main;
using Leagueoflegends.ExampleData.Friends;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotcore;
using Leagueoflegends.Friends.Local.Collection;
using Leagueoflegends.LayoutSupport.Controls;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Leagueoflegends.Friends.Local.ViewModel
{
	public class AddFriendsViewModel : ObservableObject
	{
		#region Variables

		private readonly Action<IRiotUI> ViewClosed;
        private string _keyword;
        private ObservableCollection<AddUserModel> _friends1;
        private ObservableCollection<AddUserModel> _friends2;
        #endregion

        #region ICommands

        public ICommand CompleteCommand { get; set; }
        public ICommand KeywordCommand { get; private set; }
        public ICommand CloseKeywordCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }
        public ICommand RequestCommand { get; private set; }
        #endregion

        #region Keyword

        public string Keyword
        {
            get { return _keyword; }
            set { _keyword = value; OnPropertyChanged(); }
        }
        #endregion

        #region Friends

        public ObservableCollection<AddUserModel> Friends1
        {
            get { return _friends1; }
            set { _friends1 = value; OnPropertyChanged(); }
        }

        public ObservableCollection<AddUserModel> Friends2
        {
            get { return _friends2; }
            set { _friends2 = value; OnPropertyChanged(); }
        }

        #endregion

        public UserCollection UserCollection { get; }

        #region Constructor

        public AddFriendsViewModel(Action<IRiotUI> _viewClosed)
        {
            UserCollection = new();

            ViewClosed = _viewClosed;

            Keyword = "";
            KeywordCommand = new RelayCommand<object>(KeywordChanged);
            CloseKeywordCommand = new RelayCommand<object>(CloseKeyword);
            CompleteCommand = new RelayCommand<object>((o) => ViewClosed.Invoke(View));
            DeleteCommand = new RelayCommand<AddUserModel>(UserCollection.SentDelete);
            RequestCommand = new RelayCommand<AddUserModel>(UserCollection.SentRequest);

            var a = ExamFriends.GetAddFriendsList();
            //UserCollection.AddRange(ExamFriends.GetAddFriendsList());
        }
        #endregion

        #region KeywordChanged

        private void KeywordChanged(object obj)
        {
            Keyword = (obj as RiotTextBox).Text;
        }
        #endregion

        #region CloseKeyword

        private void CloseKeyword(object obj)
        {
            Keyword = "";
        }
        #endregion
	}
}
