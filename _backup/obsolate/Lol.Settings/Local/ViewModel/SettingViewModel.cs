using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using DevNcore.LayoutSupport.Leagueoflegends.Controls.Primitives;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Lol.Data.Setting;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using Lol.Foundation.Riotbase;
using Lol.Settings.About.UI.Views;
using Lol.Settings.Client.UI.Views;
using Lol.Settings.InGame.UI.Views;
using Lol.Settings.UI.Views;
using Lol.Support.Local.Helpers;
using Prism.Ioc;
using Prism.Regions;

namespace Lol.Settings.Local.ViewModel
{
    public partial class SettingViewModel : ObservableBase, IViewLoadable
    {
        [ObservableProperty]
        private IRiotUI _currentView;
        [ObservableProperty]
        private SettingMenus _currentSettingMenu;
        [ObservableProperty]
        private List<SettingMenus> _settingMenus;
        private readonly MenuService _menuService;
        private readonly IContainerProvider _containerProvider;
        private readonly IRegionManager _regionManager;

        public SettingViewModel(MenuService menuService,
                                IContainerProvider containerProvider,
                                IRegionManager regionManager)
        {
            _menuService = menuService;
            _containerProvider = containerProvider;
            _regionManager = regionManager;
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

            // TODO : 각 컨텐츠의 모델 데이터 불러오는 기능 구현해야함 2023/09/15
            SettingModel setting = RiotConfig.Config.Settings;
            // setting.General = General.Model;
            // setting.Alarm = Alarm.Model;
            // setting.Chat = Chat.Model;
            // setting.Sound = Sound.Model;
            // setting.Voice = Voice.Model;
            // setting.HotKey = HotKey.Model;
            // setting.GameSound = GameSound.Model;
            // setting.Interface = Interface.Model;
            // setting.Game = Game.Model;

            RiotConfig.SaveSettings(setting);
        }
        

        private void SettingMenuChanged(SettingMenus value)
        {
            if (value == null)
                return;
            string content;
            
            int key = value.Seq;
            content = value.Seq switch
            {
                // Client
                1 =>  nameof(GeneralContent),
                2 => nameof( AlarmContent),
                3 => nameof( ChatContent),
                4 => nameof( SoundContent),
                5 => nameof( VoiceContent),
                6 => nameof( BlockContent),

                // In-Game
                8 => nameof( HotKeyContent),
                9 => nameof( GameSoundContent),
                10 => nameof( InterfaceContent),
                11 => nameof( GameContent),
                12 => nameof( ReplayContent),

                // About
                14 => nameof( VerificationContent),
                _ => nameof(EmptyContent)
            };

            IRegion region = _regionManager.Regions["SettingContentRegion"];
            IViewable view =_containerProvider.Resolve<IViewable>(content);
            if(!region.Views.Contains(view))
            {
                region.Add(view);
            }
            region.Activate(view);
        }

        public void OnLoaded(IViewable view)
        {
            SettingMenus = new SettingsApi ().GetSettingMenus ();
            CurrentSettingMenu = this.SettingMenus.FirstOrDefault (x => x.Seq == 1);
        }
    }
}
