using LeagueOfLegends.Settings;
using System;

namespace LeagueOfLegends
{
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App()
                .AddInversionModule<ViewModules>()
                .Run();
        }
    }
}
