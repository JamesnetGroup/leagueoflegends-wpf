using Lol.Data.Codes;
using Lol.Data.Config;
using Lol.Data.Setting.Clients;
using Lol.DBEntity.Local.Api;
using Lol.DBEntity.Local.Entities.Extend;
using Lol.ExampleData.Setting;
using Lol.Foundation.Mvvm;
using Lol.Foundation.Riotbase;
using System.Collections.Generic;

namespace Lol.Settings.Client.Local.ViewModels
{
    public class VoiceViewModel : ObservableObject
    {
        private List<AudioDevice> _deviceList;
        private List<UsualCodes> _inputMode;

        public VoiceModel Model { get; set; }

        #region DeviceList

        public List<AudioDevice> DeviceList
        {
            get => _deviceList;
            set { _deviceList = value; OnPropertyChanged(); }
        }
        #endregion

        #region InputMode

        public List<UsualCodes> InputMode
        {
            get => _inputMode;
            set { _inputMode = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public VoiceViewModel()
        {
            DeviceList = ExamSettings.GetAudioDeviceList();
            InputMode = new GetCodeItems().Run("000001");

            ConfigModel config = RiotConfig.LoadConfig();
            Model = config.Settings.Voice;
        }
        #endregion
    }
}
