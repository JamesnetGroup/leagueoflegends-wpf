using Leagueoflegends.Data.Setting;

namespace Leagueoflegends.Data.Config
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
