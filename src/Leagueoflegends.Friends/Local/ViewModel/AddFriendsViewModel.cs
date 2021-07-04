using Leagueoflegends.Data.Main;
using Leagueoflegends.DBEntity.Local.Api;
using Leagueoflegends.DBEntity.Local.Entities.Schema;
using Leagueoflegends.ExampleData.Friends;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotcore;
using Leagueoflegends.Friends.Local.Collection;
using Leagueoflegends.Friends.Local.Model;
using Leagueoflegends.LayoutSupport.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

        public FriendsCollection UserCollection { get; }

        #region Constructor

        public AddFriendsViewModel(Action<IRiotUI> _viewClosed)
        {
            UserCollection = new();

            ViewClosed = _viewClosed;

            Keyword = "";
            KeywordCommand = new RelayCommand<object>(KeywordChanged);
            CloseKeywordCommand = new RelayCommand<object>(CloseKeyword);
            CompleteCommand = new RelayCommand<object>((o) => ViewClosed.Invoke(View));
            DeleteCommand = new RelayCommand<ReqestFriends>(UserCollection.SentDelete);
            RequestCommand = new RelayCommand<ReqestFriends>(UserCollection.SentRequest);

            var data = new GetSentFriends().Run(0);
            UserCollection.AddRange(data);
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
