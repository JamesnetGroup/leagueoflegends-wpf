using Leagueoflegends;
using System.Windows;

namespace leagueoflegends
{
    public partial class App : Application
    {
        public App()
        {
            var bootstrapper = new LeagueOfLegendsBootstrapper();
            bootstrapper.Run();
        }
    }

}
