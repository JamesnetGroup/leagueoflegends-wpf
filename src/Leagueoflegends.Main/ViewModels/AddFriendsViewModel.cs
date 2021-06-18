using Leagueoflegends.Data.Main;
using Leagueoflegends.LayoutSupport.Controls;
using Leagueoflegends.Windowbase.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace Leagueoflegends.Main.ViewModels
{
	public class AddFriendsViewModel : ObservableObject
	{
        #region Command
        public ICommand CompleteCommand { get; set; }
        public ICommand KeywordCommand { get; private set; }
        public ICommand CloseKeywordCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }
        public ICommand RequestCommand { get; private set; }
        #endregion

        #region Keyword

        private string _keyword;
        public string Keyword
        {
            get { return _keyword; }
            set { _keyword = value; OnPropertyChanged(); }
        }
        #endregion

        #region Friends

        private ObservableCollection<AddFriendsModel> _friends1;
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

        public AddFriendsViewModel()
        {
            Keyword = "";
            KeywordCommand = new RelayCommand<object>(KeywordChanged);
            CloseKeywordCommand = new RelayCommand<object>(CloseKeyword);
            CompleteCommand = new RelayCommand<DarkBackground>(CompleteClick);
            DeleteCommand = new RelayCommand<object>(DeleteClick);
            RequestCommand = new RelayCommand<object>(RequestClick);
            InitFriends();
        }

        #endregion

        #region InitFriends

        private void InitFriends()
        {
            var friends = new List<AddFriendsModel>
            {
                new AddFriendsModel { IsSent = true, NickName = "elenakim", UserID = "elenakim", Nation = "KR", Level = 5, Avatar="/Leagueoflegends.Resources;component/Images/Square/0.png" },
                new AddFriendsModel { IsSent = false, NickName = "조이블랑탈론", UserID = "joyblang", Nation = "KR", Level = 178, Avatar="/Leagueoflegends.Resources;component/Images/Square/1.png" },
                new AddFriendsModel { IsSent = false, NickName = "야 허건 넣을게", UserID = "yayaya", Nation = "KR", Level = 12, Avatar="/Leagueoflegends.Resources;component/Images/Square/10.png" },
                new AddFriendsModel { IsSent = false, NickName = "명학이는 명학해", UserID = "myunghak", Nation = "KR", Level = 33, Avatar="/Leagueoflegends.Resources;component/Images/Square/11.png" },
                new AddFriendsModel { IsSent = false, NickName = "짱루짱무", UserID = "jjangllu", Nation = "KR", Level = 25, Avatar="/Leagueoflegends.Resources;component/Images/Square/12.png" },
                new AddFriendsModel { IsSent = false, NickName = "이 진 썩", UserID = "leejin", Nation = "KR", Level = 54, Avatar="/Leagueoflegends.Resources;component/Images/Square/13.png" },
                new AddFriendsModel { IsSent = false, NickName = "flyETH", UserID = "flyETH", Nation = "US", Level = 5, Avatar="/Leagueoflegends.Resources;component/Images/Square/14.png" },
                new AddFriendsModel { IsSent = false, NickName = "생각좀해라서폿아", UserID = "thinkkk", Nation = "KR", Level = 71, Avatar="/Leagueoflegends.Resources;component/Images/Square/15.png" },
                new AddFriendsModel { IsSent = false, NickName = "개뒷치기", UserID = "wallwall", Nation = "KR", Level = 5, Avatar="/Leagueoflegends.Resources;component/Images/Square/16.png" },
                new AddFriendsModel { IsSent = false, NickName = "234923058205", UserID = "2349230", Nation = "CH", Level = 2, Avatar="/Leagueoflegends.Resources;component/Images/Square/17.png" },
                new AddFriendsModel { IsSent = false, NickName = "MAYBLE", UserID = "MAYBLE", Nation = "UK", Level = 14, Avatar="/Leagueoflegends.Resources;component/Images/Square/18.png" },
                new AddFriendsModel { IsSent = false, NickName = "다마고치 썸", UserID = "ssum", Nation = "KR", Level = 3, Avatar="/Leagueoflegends.Resources;component/Images/Square/19.png" },
                new AddFriendsModel { IsSent = false, NickName = "준우는휴가철", UserID = "jjun", Nation = "KR", Level = 45, Avatar="/Leagueoflegends.Resources;component/Images/Square/2.png" },
                new AddFriendsModel { IsSent = false, NickName = "대구박살남친구", UserID = "dkfff", Nation = "KR", Level = 5, Avatar="/Leagueoflegends.Resources;component/Images/Square/20.png" },
                new AddFriendsModel { IsSent = false, NickName = "햄버거피자짜장면", UserID = "hungry", Nation = "KR", Level = 92, Avatar="/Leagueoflegends.Resources;component/Images/Square/21.png" },
                new AddFriendsModel { IsSent = false, NickName = "이응5", UserID = "okayokay", Nation = "KR", Level = 5, Avatar="/Leagueoflegends.Resources;component/Images/Square/22.png" },
                new AddFriendsModel { IsSent = false, NickName = "GIVE ME BUSH", UserID = "bushmegive", Nation = "CA", Level = 10, Avatar="/Leagueoflegends.Resources;component/Images/Square/23.png" },
                new AddFriendsModel { IsSent = false, NickName = "바위개와칼날부리", UserID = "rockaby", Nation = "KR", Level = 63, Avatar="/Leagueoflegends.Resources;component/Images/Square/24.png" },
                new AddFriendsModel { IsSent = false, NickName = "단무지두장", UserID = "jjajang", Nation = "KR", Level = 42, Avatar="/Leagueoflegends.Resources;component/Images/Square/25.png" },
                new AddFriendsModel { IsSent = false, NickName = "시방누구여", UserID = "whoareyou", Nation = "KR", Level = 60, Avatar="/Leagueoflegends.Resources;component/Images/Square/26.png" },
                new AddFriendsModel { IsSent = false, NickName = "댁 우", UserID = "daeckwoo", Nation = "KR", Level = 2, Avatar="/Leagueoflegends.Resources;component/Images/Square/27.png" },
                new AddFriendsModel { IsSent = false, NickName = "세라핑핑이", UserID = "pingping", Nation = "KR", Level = 5, Avatar="/Leagueoflegends.Resources;component/Images/Square/28.png" },
                new AddFriendsModel { IsSent = false, NickName = "슈퍼아파트", UserID = "superduper", Nation = "KR", Level = 58, Avatar="/Leagueoflegends.Resources;component/Images/Square/29.png" },
                new AddFriendsModel { IsSent = false, NickName = "와르르맨숀", UserID = "jjanggu", Nation = "KR", Level = 7, Avatar="/Leagueoflegends.Resources;component/Images/Square/3.png" },
                new AddFriendsModel { IsSent = false, NickName = "집게사장", UserID = "sponge", Nation = "KR", Level = 32, Avatar="/Leagueoflegends.Resources;component/Images/Square/30.png" },
                new AddFriendsModel { IsSent = false, NickName = "꼬북좌", UserID = "kkobbuk", Nation = "KR", Level = 37, Avatar="/Leagueoflegends.Resources;component/Images/Square/31.png" },
                new AddFriendsModel { IsSent = false, NickName = "칙칙한초코칩", UserID = "chochock", Nation = "KR", Level = 74, Avatar="/Leagueoflegends.Resources;component/Images/Square/32.png" },
                new AddFriendsModel { IsSent = false, NickName = "4598583233", UserID = "4598583233", Nation = "JP", Level = 1, Avatar="/Leagueoflegends.Resources;component/Images/Square/33.png" },
                new AddFriendsModel { IsSent = false, NickName = "퇴사언제하지", UserID = "quitjob", Nation = "KR", Level = 3, Avatar="/Leagueoflegends.Resources;component/Images/Square/34.png" }
            };

            Friends1 = new ObservableCollection<AddFriendsModel>(friends.Where(x => x.IsSent == true));
            Friends2 = new ObservableCollection<AddFriendsModel>(friends.Where(x => x.IsSent == false));
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
            if (obj.DataContext is MainViewModel vm)
            {
                vm.IsModalVisible = false;
            }
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
