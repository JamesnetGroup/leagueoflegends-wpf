using Leagueoflegends.Friends.ViewModels;
using Leagueoflegends.Friends.Views;
using Leagueoflegends.Main.ViewModels;
using Leagueoflegends.Settings.ViewModels;
using Leagueoflegends.Settings.Views;
using Leagueoflegends.Windowbase.Riotcore;
using System;
using System.Collections.Generic;
using System.Windows;

namespace Leagueoflegends.Main.Local.Works
{
	public class ContentWork
	{
		#region Variables 

		private MainViewModel _view;
		private Dictionary<Type, IRiotUI> _modals;
		#endregion

		#region Constructor

		public ContentWork(MainViewModel view)
		{
			_view = view;
			_modals = new();
		}
		#endregion

		internal void SwitchModal(Type type)
		{
			IRiotUI content = null;

			if (typeof(SettingView) == type) content = ShowSettingView(type);
			if (typeof(AddFriendsView) == type) content = ShowAddFreidns(type);

			_view.ModalContent = content;
		}

		private IRiotUI ShowSettingView(Type type)
		{
			if (!_modals.ContainsKey(type))
			{
				var vm = new SettingViewModel(ModalClose);
				var view = new SettingView().UseViewModel(vm);
				_modals.Add(type, view);
			}

			return _modals[type];
		}

		private IRiotUI ShowAddFreidns(Type type)
		{
			if (!_modals.ContainsKey(type))
			{
				var vm = new AddFriendsViewModel(ModalClose);
				var view = new AddFriendsView();
				_modals.Add(type, view);
			}

			return _modals[type];
		}

		private void ModalClose(IRiotUI ui)
		{
			_view.ModalContent = null;
		}
	}
}
