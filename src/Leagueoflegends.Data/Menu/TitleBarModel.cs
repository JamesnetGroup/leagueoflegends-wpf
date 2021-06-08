using System.Windows.Input;

namespace Leagueoflegends.Data.Menu
{
	public class TitleBarModel
	{
		public string Name { get; set; }
		public ICommand TitleBarSelectCommand { get; set; }

		public TitleBarModel(string name)
		{
			Name = name;
		}
	}
}
