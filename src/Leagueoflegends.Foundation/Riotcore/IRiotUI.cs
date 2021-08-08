using Leagueoflegends.Data.Main;
using Leagueoflegends.Foundation.Mvvm;

namespace Leagueoflegends.Foundation.Riotcore
{
    public interface IRiotUI
    {
        IRiotUI SetVM(ObservableObject vm);
        void Show(SubMenuModel menu);
    }
}
