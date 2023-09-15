using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using DevNcore.LayoutSupport.Leagueoflegends.Controls.Primitives;
using Jamesnet.Wpf.Mvvm;
using Lol.Data.Setting;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using Lol.Foundation.Riotbase;
using Lol.Settings.About.Local.ViewModels;
using Lol.Settings.About.UI.Views;
using Lol.Settings.Client.Local.ViewModels;
using Lol.Settings.Client.UI.Views;
using Lol.Settings.InGame.Local.ViewModels;
using Lol.Settings.InGame.UI.Views;
using Lol.Settings.UI.Views;
using Lol.Support.Local.Helpers;

namespace Lol.Settings.Local.ViewModel
{
    public partial class SettingViewModel : ObservableBase
    {
        [ObservableProperty]
        private IRiotUI _currentView;
        [ObservableProperty]
        private SettingMenus _currentSettingMenu;
        [ObservableProperty]
        private List<SettingMenus> _settingMenus;

        private readonly Action<IRiotUI> ViewClosed;
        private readonly AlarmViewModel Alarm;
        private readonly ChatViewModel Chat;
        private readonly GeneralViewModel General;
        private readonly SoundViewModel Sound;
        private readonly VoiceViewModel Voice;
        private readonly HotKeyViewModel HotKey;
        private readonly GameSoundViewModel GameSound;
        private readonly InterfaceViewModel Interface;
        private readonly GameViewModel Game;
        private readonly MenuService _menuService;

        private Dictionary<int, IRiotUI> UIs { get; set; }


        public SettingViewModel(MenuService menuService)
        {
            _menuService = menuService;
            UIs = new();
            General = new GeneralViewModel();
            Alarm = new AlarmViewModel();
            Chat = new ChatViewModel();
            Sound = new SoundViewModel();
            Voice = new VoiceViewModel();
            HotKey = new HotKeyViewModel();
            GameSound = new GameSoundViewModel();
            Interface = new InterfaceViewModel();
            Game = new GameViewModel();

            SettingMenus = new SettingsApi().GetSettingMenus();
            CurrentSettingMenu = this.SettingMenus.FirstOrDefault(x => x.Seq == 1); 
        }

        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            string propertyName = e.PropertyName;
            if (propertyName == "CurrentSettingMenu")
            {
                SettingMenuChanged(CurrentSettingMenu);
            }
        }

        [RelayCommand]
        private void Complete(Modal obj)
        {
            _menuService.CloseModal();

            SettingModel setting = RiotConfig.Config.Settings;
            setting.General = General.Model;
            setting.Alarm = Alarm.Model;
            setting.Chat = Chat.Model;
            setting.Sound = Sound.Model;
            setting.Voice = Voice.Model;
            setting.HotKey = HotKey.Model;
            setting.GameSound = GameSound.Model;
            setting.Interface = Interface.Model;
            setting.Game = Game.Model;

            RiotConfig.SaveSettings(setting);
        }
        

        private void SettingMenuChanged(SettingMenus value)
        {
            IRiotUI content;
            int key;

            if (value != null)
            {
                key = value.Seq;
                content = value.Seq switch
                {
                    // Client
                    1 => new GeneralView().SetVM(General),
                    2 => new AlarmView().SetVM(Alarm),
                    3 => new ChatView().SetVM(Chat),
                    4 => new SoundView().SetVM(Sound),
                    5 => new VoiceView().SetVM(Voice),
                    6 => new BlockView().SetVM(new BlockViewModel()),

                    // In-Game
                    8 => new HotKeyView().SetVM(HotKey),
                    9 => new GameSoundView().SetVM(GameSound),
                    10 => new InterfaceView().SetVM(Interface),
                    11 => new GameView().SetVM(Game),
                    12 => new ReplayView().SetVM(new ReplayViewModel()),

                    // About
                    14 => new VerificationView().SetVM(new VerificationViewModel()),
                    _ => new EmptyView()
                };

                if (!UIs.ContainsKey(key))
                {
                    UIs.Add(key, content);
                }

                CurrentView = UIs[key];
            }
        }
    }
}
