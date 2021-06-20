using Leagueoflegends.Data.Main;
using Leagueoflegends.ExampleData.Friends;
using Leagueoflegends.Friends.ViewModels;
using Leagueoflegends.Friends.Views;
using Leagueoflegends.Home.General.ViewModels;
using Leagueoflegends.Home.General.Views;
using Leagueoflegends.LayoutSupport.Common.UIObject;
using Leagueoflegends.Main.Views;
using Leagueoflegends.Menus.ViewModels;
using Leagueoflegends.MyShop.ViewModels;
using Leagueoflegends.MyShop.Views;
using Leagueoflegends.Options.ViewModels;
using Leagueoflegends.TeamFight.ViewModels;
using Leagueoflegends.TeamFight.Views;
using Leagueoflegends.TitleBar.ViewModels;
using Leagueoflegends.Windowbase.Mvvm;
using Leagueoflegends.Windowbase.Riotcore;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace Leagueoflegends.Main.ViewModels
{
	public class MainViewModel : ObservableObject, IModalUIObject
	{
		#region Variables

		private bool _isModalVisible;
		private bool _isPopupVisible;
		private object _modalContent;
		private IRiotUIElement _currentUI;
		private List<SubMenuModel> _subMenus;
		private SubMenuModel _currentSubMenu;
		private MainMenuModel _mainMenu;
		private List<CommunityModel> _friends;
		private Dictionary<string, IRiotUIElement> UIs { get; set; }
		#endregion

		#region ViewModels

		public MainMenuViewModel MainMenu { get; }
		public TitleBarViewModel TitleBar { get; }
		public OptionsViewModel Options { get; }
		#endregion

		#region ICommands

		public ICommand ShowPopupCommand { get; set; }
		#endregion

		#region ModalContent

		public object ModalContent
		{
			get { return _modalContent; }
			set { _modalContent = value; OnPropertyChanged(); }
		}
		#endregion

		#region IsModalVisible

		public bool IsModalVisible
		{
			get { return _isModalVisible; }
			set { _isModalVisible = value; OnPropertyChanged(); }
		}
		#endregion

		#region IsPopupVisible

		public bool IsPopupVisible
		{
			get { return _isPopupVisible; }
			set { _isPopupVisible = value; OnPropertyChanged(); }
		}
		#endregion

		#region CurrentUI

		public IRiotUIElement CurrentUI
		{
			get => _currentUI;
			set { _currentUI = value; OnPropertyChanged(); }
		}
		#endregion

		#region SubMenus

		public SubMenuModel CurrentSubMenu
		{
			get => _currentSubMenu;
			set { _currentSubMenu = value; OnPropertyChanged(); SubMenuChanged(value); }
		}


		public List<SubMenuModel> SubMenus
		{
			get => _subMenus;
			set { _subMenus = value; OnPropertyChanged(); }
		}

		#endregion

		#region Friends

		public List<CommunityModel> Friends
		{
			get => _friends;
			set { _friends = value; OnPropertyChanged(); }
		}

		public int TotalFriendsCount { get; set; }
		public int GeneralFriendsCount { get; set; }
		public int OfflineFriendsCount { get; set; }
		#endregion

		#region Constructor

		public MainViewModel()
		{
			UIs = new();
			ShowPopupCommand = new RelayCommand<string>(ShowModal);
			TitleBar = new();
			MainMenu = new(MenuSelected);
			Options = new();

			Friends = ExamFriends.GetFriendsList();
			GeneralFriendsCount = Friends[0].Children.Count();
			OfflineFriendsCount = Friends[1].Children.Count();
			TotalFriendsCount = GeneralFriendsCount + OfflineFriendsCount;
		}
		#endregion

		// public..♥

		#region ShowModal

		public void ShowModal(string obj)
		{
			switch (obj.ToString())
			{
				case "ADD FRIENDS":
					ModalContent = new AddFriendsView().UseViewModel(new AddFriendsViewModel(AddFriendsViewClosed));
					IsModalVisible = true;
					break;
				case "OPTIONS":
					IsPopupVisible = !IsPopupVisible;
					break;
				default:
					break;
					//case "SETTING":
					//	ModalContent = new SettingView();
					//	IsModalVisible = true;
					//	break;
					//case "ADD CHAMPION":
					//	ModalContent = new AddChampionView();
					//	IsModalVisible = true;
					//	break;
			}
		}
		#endregion

		// Private..♥

		#region MenuSelected

		private void MenuSelected(MainMenuModel menu, List<SubMenuModel> subMenus)
		{
			_mainMenu = menu;
			SubMenus = subMenus;
			CurrentSubMenu = SubMenus.FirstOrDefault();
		}
		#endregion

		#region SubMenuChanged

		private void SubMenuChanged(SubMenuModel value)
		{
			IRiotUIElement content;
			string key;

			if (value != null)
			{
				key = value.Name;
				content = value.Seq switch
				{
					0 => new GeneralView().UseViewModel(new GeneralViewModel()),
					_ => new EmptyContent()
				};
			}
			else
			{
				key = _mainMenu.Name;
				content = _mainMenu.Seq switch
				{
					1 => new TeamFightView().UseViewModel(new TeamFightViewModel()),
					6 => new MyShopView().UseViewModel(new MyShopViewModel()),
					_ => new EmptyContent()
				};
			}

			if (!UIs.ContainsKey(key))
			{
				UIs.Add(key, content);
			}

			CurrentUI = UIs[key];
		}
		#endregion

		// Callback..♥

		#region AddFriendsViewClosed

		private void AddFriendsViewClosed(object obj)
		{
			IsModalVisible = false;
		}
		#endregion
	}
}