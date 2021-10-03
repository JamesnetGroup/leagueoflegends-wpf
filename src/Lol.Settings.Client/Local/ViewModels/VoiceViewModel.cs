using Lol.Data.Codes;
using Lol.Data.Config;
using Lol.Data.Setting.Clients;
using Lol.Devices.Audio;
using Lol.Foundation.Mvvm;
using Lol.Foundation.Riotbase;
using Lol.YamlDatabase.Controller;
using Lol.YamlDatabase.Entites.Schema;
using System.Collections.Generic;

namespace Lol.Settings.Client.Local.ViewModels
{
    public class VoiceViewModel : ObservableObject
    {
        #region Variables

        private List<AudioDevice> _deviceList;
        private List<UsualCodes> _inputMode;
        #endregion

        #region Model

        public VoiceModel Model { get; set; }
        #endregion

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
            DeviceList = new AudioDeviceInfo().GetDevices();
            InputMode = new CodesApi().GetCodes("000001");

            ConfigModel config = RiotConfig.LoadConfig();
            Model = config.Settings.Voice;
        }
        #endregion
    }
}
