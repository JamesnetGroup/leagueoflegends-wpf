using Leagueoflegends.Data.Menu;
using Leagueoflegends.Windowbase.Mvvm;

namespace Leagueoflegends.Windowbase.Riotcore
{
	public interface IRiotUIElement
	{
		IRiotUIElement UseViewModel(ObservableObject vm);
		void Show(SubMenuModel menu);
	}
}
