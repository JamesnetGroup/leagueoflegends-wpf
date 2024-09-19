using Leagueoflegends;
using System.Windows;

namespace leagueoflegends
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var bootstrapper = new LeagueOfLegendsBootstrapper();
            bootstrapper.Run();
        }
    }

}
