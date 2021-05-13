using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leagueoflegends
{
    public class Startup
    {
        [STAThread]
        public static void Main(string[] args)
        {
            new App().Run();
        }
    }
}
