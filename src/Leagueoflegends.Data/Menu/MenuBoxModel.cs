using System.Windows.Input;

namespace Leagueoflegends.Data.Menu
{
	public class MenuBoxModel
	{
		public string Name { get; set; }
		public ICommand MenuSelectCommand { get; set; }

		public MenuBoxModel(string name)
		{
			Name = name;
		}
	}
}
