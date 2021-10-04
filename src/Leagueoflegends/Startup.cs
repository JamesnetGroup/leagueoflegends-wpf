using System;

namespace Leagueoflegends
{
    public class Startup
    {
        [STAThread]
        public static void Main(string[] args)
        {
            _ = new App().Run();
        }
    }
}