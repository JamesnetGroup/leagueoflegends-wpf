using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.Database.Entites.Schema
{
    public class LobbyLists
    {
        public int Seq { get; set; }
        public string Lobby { get; set; }
        public string Host { get; set; }
        public string Map { get; set; }
        public string TotalNumber { get; set; }
        public string Spectator { get; set; }
        public bool Watching { get; set; }
        public bool Private { get; set; }
    }
}
