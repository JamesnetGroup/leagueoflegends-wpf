using System.Windows.Input;

namespace Leagueoflegends.Data.Menu
{
	public class MenuBoxModel
	{
		public int Seq { get; set; }
		public string Name { get; set; }
		public string MenuType { get; set; }
		public ICommand MenuSelectCommand { get; set; }

		public MenuBoxModel(int seq, string name, string type)
		{
			Seq = seq;
			Name = name;
			MenuType = type;
		}
	}
}
