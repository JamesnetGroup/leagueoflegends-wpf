using Leagueoflegends.Data.Main;
using Leagueoflegends.ExampleData.Friends;
using Leagueoflegends.LayoutSupport.Controls;
using Leagueoflegends.Windowbase.Mvvm;
using Leagueoflegends.Windowbase.Riotcore;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace Leagueoflegends.Friends.ViewModels
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

        #region Constructor

        public AddFriendsViewModel(Action<IRiotUI> _viewClosed)
        {
            ViewClosed = _viewClosed;

            Keyword = "";
            KeywordCommand = new RelayCommand<object>(KeywordChanged);
            CloseKeywordCommand = new RelayCommand<object>(CloseKeyword);
            CompleteCommand = new RelayCommand<Modal>(CompleteClick);
            DeleteCommand = new RelayCommand<object>(DeleteClick);
            RequestCommand = new RelayCommand<object>(RequestClick);

            var friends = ExamFriends.GetAddFriendsList();
            Friends1 = new(friends.Where(x => x.IsSent));
            Friends2 = new(friends.Where(x => x.IsSent == false));
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

        #region CompleteClick

        private void CompleteClick(Modal obj)
        {
            ViewClosed.Invoke(View);
        }
		#endregion

		#region DeleteClick

		private void DeleteClick(object obj)
        {
            if (obj is AddUserModel model)
            {
                Friends1.Remove(model);
            }
        }
		#endregion

		#region RequestClick

		private void RequestClick(object obj)
        {
            if (obj is AddUserModel model)
            {
                Friends2.Remove(model);
                model.IsSent = true;

                Friends1.Add(model);
            }
        }
		#endregion
	}
}
