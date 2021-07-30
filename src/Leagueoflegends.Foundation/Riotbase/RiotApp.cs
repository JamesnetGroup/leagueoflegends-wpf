using System;
using System.IO;
using System.Windows;

namespace Leagueoflegends.Foundation.Riotbase
{
	public class RiotApp : Application
	{
        public static string REPLAY_PATH;
        public static string HIGHLIGHT_PATH;

        static RiotApp()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            REPLAY_PATH = Path.Combine(path, "League of Legends\\Replays");
            HIGHLIGHT_PATH = Path.Combine(path, "League of Legends\\Highlights");
        }
    }
}
