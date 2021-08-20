using Lol.Data.Setting;

namespace Lol.Data.Config
{
    public class ConfigModel
    {
        public SettingModel Settings { get; set; }

        public ConfigModel()
        {
            Settings = new SettingModel();
        }
    }
}
