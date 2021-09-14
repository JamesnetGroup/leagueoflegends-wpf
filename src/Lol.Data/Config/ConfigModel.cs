using Lol.Data.Setting;

namespace Lol.Data.Config
{
    public class ConfigModel
    {
        public SettingModel Settings { get; set; }

        #region Constructor

        public ConfigModel()
        {
            Settings = new SettingModel();
        }
        #endregion
    }
}
