using System;
using System.IO;
using System.Windows;

namespace Lol.Foundation.Riotbase
{
    public class RiotApp : Application
    {
        // TODO: [James] Non-constant fields should not be visible 메시지 해결 필요!
        public static string REPLAY_PATH;
        public static string HIGHLIGHT_PATH;

        static RiotApp()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            REPLAY_PATH = Path.Combine(path, @"League of Legends\Replays");
            HIGHLIGHT_PATH = Path.Combine(path, @"League of Legends\Highlights");
        }
    }
}
