using Leagueoflegends.Data.Main;
using Leagueoflegends.ExampleData.Friends;
using Leagueoflegends.LayoutSupport.Controls;
using Leagueoflegends.Windowbase.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace Leagueoflegends.Friends.ViewModels
{
	public class AddFriendsViewModel : ObservableObject
	{
		#region Variables

		private Action<object> ViewClosed;
        private string _keyword;
        private ObservableCollection<AddFriendsModel> _friends1;
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

        public ObservableCollection<AddFriendsModel> Friends1
        {
            get { return _friends1; }
            set { _friends1 = value; OnPropertyChanged(); }
        }

        private ObservableCollection<AddFriendsModel> _friends2;
        public ObservableCollection<AddFriendsModel> Friends2
        {
            get { return _friends2; }
            set { _friends2 = value; OnPropertyChanged(); }
        }

        #endregion

        #region Constructor

        public AddFriendsViewModel(Action<object> _viewClosed)
        {
            ViewClosed = _viewClosed;

            Keyword = "";
            KeywordCommand = new RelayCommand<object>(KeywordChanged);
            CloseKeywordCommand = new RelayCommand<object>(CloseKeyword);
            CompleteCommand = new RelayCommand<DarkBackground>(CompleteClick);
            DeleteCommand = new RelayCommand<object>(DeleteClick);
            RequestCommand = new RelayCommand<object>(RequestClick);

            var friends = ExamFriends.GetAddFriendsList();
            Friends1 = new(friends.Where(x => x.IsSent == true));
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

        private void CompleteClick(DarkBackground obj)
        {
            ViewClosed.Invoke(this);
        }
		#endregion

		#region DeleteClick

		private void DeleteClick(object obj)
        {
            if (obj is AddFriendsModel model)
            {
                Friends1.Remove(model);
            }
        }
		#endregion

		#region RequestClick

		private void RequestClick(object obj)
        {
            if (obj is AddFriendsModel model)
            {
                Friends2.Remove(model);
                model.IsSent = true;

                Friends1.Add(model);
            }
        }
		#endregion
	}
}
