using System;
using System.IO;
using Lol.Data.Config;
using Lol.Data.Setting;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Lol.Foundation.Riotbase
{
    public class RiotConfig
    {
        #region Variables

        public static string WIN_PATH { get; }
        public static string SYS_PATH { get; }
        public static string CFG_PATH { get; }
        public static ConfigModel Config { get; private set; }
        #endregion

        #region Constructor

        static RiotConfig()
        {
            WIN_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            SYS_PATH = string.Format(@"{0}\Riot\System", WIN_PATH);
            CFG_PATH = string.Format(@"{0}\Config.yaml", SYS_PATH);

            LoadConfigFile();
        }
        #endregion

        #region LoadConfigFile

        private static void LoadConfigFile()
        {
            if (!Directory.Exists(SYS_PATH))
            {
                _ = Directory.CreateDirectory(SYS_PATH);
            }

            if (!File.Exists(CFG_PATH))
            {
                SaveConfig(new ConfigModel());
            }

            var deserializer = new DeserializerBuilder()
              .WithNamingConvention(new CamelCaseNamingConvention())
              .Build();

            Config = deserializer.Deserialize<ConfigModel>(File.ReadAllText(CFG_PATH));
        }
        #endregion

        #region LoadConfig

        public static ConfigModel LoadConfig()
        {
            return Config;
        }
        #endregion

        #region SaveSettings

        public static void SaveSettings(SettingModel set)
        {
            Config.Settings = set;
            SaveConfig(Config);
        }
        #endregion

        #region SaveConfig

        private static void SaveConfig(ConfigModel config)
        {
            var serializer = new SerializerBuilder()
                .WithNamingConvention(new CamelCaseNamingConvention())
                .Build();

            string yaml = serializer.Serialize(config);

            File.WriteAllText(CFG_PATH, yaml);
        }
        #endregion
    }
}
