using Leagueoflegends.Data.Main;
using Leagueoflegends.Windowbase.Mvvm;

namespace Leagueoflegends.Windowbase.Riotcore
{
	public interface IRiotUI
	{
		IRiotUI SetVM(ObservableObject vm);
		void Show(SubMenuModel menu);
	}
}
