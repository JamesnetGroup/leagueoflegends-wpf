using Leagueoflegends.Data.Main;
using Leagueoflegends.ExampleData.Friends;
using Leagueoflegends.Friends.ViewModels;
using Leagueoflegends.Friends.Views;
using Leagueoflegends.Home.General.ViewModels;
using Leagueoflegends.Home.General.Views;
using Leagueoflegends.LayoutSupport.Common.UIObject;
using Leagueoflegends.Main.Local.Works;
using Leagueoflegends.Main.Views;
using Leagueoflegends.Menus.ViewModels;
using Leagueoflegends.MyShop.ViewModels;
using Leagueoflegends.MyShop.Views;
using Leagueoflegends.Options.ViewModels;
using Leagueoflegends.Settings.ViewModels;
using Leagueoflegends.Settings.Views;
using Leagueoflegends.TeamFight.ViewModels;
using Leagueoflegends.TeamFight.Views;
using Leagueoflegends.Windowbase.Mvvm;
using Leagueoflegends.Windowbase.Riotcore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Leagueoflegends.Main.ViewModels
{
	public class MainViewModel : ObservableObject, IModalUIObject
	{
		#region Variables

		private readonly WindowWork _winWork;
		private readonly ContentWork _viewWork;

		private bool _isModalVisible;
		private object _modalContent;
		private IRiotUI _currentUI;
		private List<SubMenuModel> _subMenus;
		private SubMenuModel _currentSubMenu;
		private MainMenuModel _mainMenu;
		private List<CommunityModel> _friends;
		private Dictionary<string, IRiotUI> UIs { get; set; }
		#endregion

		

		#region ViewModels

		public MainMenuViewModel MainMenu { get; }
		public OptionsViewModel Options { get; }
		#endregion

		#region ICommands

		public ICommand ShowPopupCommand { get; }
		public ICommand ModalCommand { get; }
		public ICommand CloseCommand { get; }
		public ICommand MinimizeCommand { get; }
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

		#region CurrentUI

		public IRiotUI CurrentUI
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
			_winWork = new(this);
			_viewWork = new(this);
			UIs = new();

			CloseCommand = new RelayCommand<object>(_winWork.DoClosing);
			MinimizeCommand = new RelayCommand<object>(_winWork.DoMinizing);
			ModalCommand = new RelayCommand<Type>(_viewWork.SwitchModal);

			//ShowPopupCommand = new RelayCommand<string>(ShowModal);
			//SwitchViewCommand = new RelayCommand<string>(SwitchView);
			MainMenu = new(MenuSelected);
			Options = new();

			Friends = ExamFriends.GetFriendsList();
			GeneralFriendsCount = Friends[0].Children.Count();
			OfflineFriendsCount = Friends[1].Children.Count();
			TotalFriendsCount = GeneralFriendsCount + OfflineFriendsCount;
		}
		#endregion

		// Public

		#region ShowModal

		public void ShowModal(string obj)
		{
			switch (obj)
			{
				case "ADD FRIENDS":
					ModalContent = new AddFriendsView().UseViewModel(new AddFriendsViewModel(AddFriendsViewClosed));
					IsModalVisible = true;
					break;
				default:
					break;
			}
		}
		#endregion

		// Private

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
			IRiotUI content;
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

		// Callback

		#region AddFriendsViewClosed

		private void AddFriendsViewClosed(object obj)
		{
			IsModalVisible = false;
		}
		#endregion

		#region SettingViewClosed

		private void SettingViewClosed(object obj)
		{
			IsModalVisible = false;
		}
		#endregion

		#region ViewClose

		private void ViewClose(object obj)
		{
			Window.GetWindow((UIElement)View).Close();
		}
		#endregion
	}
}