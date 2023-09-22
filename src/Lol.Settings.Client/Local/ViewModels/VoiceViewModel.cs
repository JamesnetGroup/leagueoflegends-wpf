using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Mvvm;
using Lol.Data.Codes;
using Lol.Data.Config;
using Lol.Data.Setting.Clients;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using Lol.Devices.Audio;
using Lol.Foundation.Riotbase;

namespace Lol.Settings.Client.Local.ViewModels
{
    public partial class VoiceViewModel : ObservableBase
    {
        [ObservableProperty]
        private List<AudioDevice> _deviceList;
        [ObservableProperty]
        private List<UsualCodes> _inputMode;
        [ObservableProperty]
        private UsualCodes _selectInputMode;
        [ObservableProperty]
        private AudioDevice _selectDevice;
        public VoiceModel Model { get; set; }

        public VoiceViewModel()
        {
            DeviceList = new AudioDeviceInfo().GetDevices();
            InputMode = new CodesApi().GetCodes("000001");

            ConfigModel config = RiotConfig.LoadConfig();
            Model = config.Settings.Voice;
            this.SelectInputMode = SearchnputMode (Model.InputMode);
            this.SelectDevice = SearchAudio (Model.InputDevice);
        }
        [RelayCommand]
        private void ChangeOutputMode(AudioDevice audioDevice)
        {
            Model.InputDevice = audioDevice.Name;
            this.SelectDevice = SearchAudio (audioDevice.Name);
        }
        [RelayCommand]
        private void ChangeVoiceMode(UsualCodes codes)
        {
            Model.InputMode = codes.ItemName;            
            SelectInputMode = SearchnputMode (codes.ItemName);
        }

        private AudioDevice SearchAudio(string name)
        {
            var search = DeviceList.FirstOrDefault (x => x.Name == name);
            if (search == null)
                return DeviceList.First ();

            return search;
        }
        private UsualCodes SearchnputMode(string ItemName)
        {
            return InputMode.FirstOrDefault (x => x.ItemName == ItemName);
        }
    }
}
