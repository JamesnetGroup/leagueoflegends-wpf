using System;

namespace Leagueoflegends
{
    public class Startup
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App().Run();
        }
    }
}