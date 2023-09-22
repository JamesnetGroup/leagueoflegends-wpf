using System.Collections.Generic;
using System.Linq;
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
        public VoiceModel Model { get; set; }

        public VoiceViewModel()
        {
            DeviceList = new AudioDeviceInfo().GetDevices();
            InputMode = new CodesApi().GetCodes("000001");

            ConfigModel config = RiotConfig.LoadConfig();
            Model = config.Settings.Voice;
            SelectInputMode = InputMode.FirstOrDefault(x=>x.ItemName == Model.InputMode);
        }

        [RelayCommand]
        private void ChangeVoiceMode(UsualCodes codes)
        {
            Model.InputMode = codes.ItemName;            
            SelectInputMode = Select (codes.ItemName);
        }

        private UsualCodes Select(string ItemName)
        {
            return InputMode.FirstOrDefault (x => x.ItemName == ItemName);
        }
    }
}
