﻿namespace Lol.YamlDatabase.Entites.Schema
{
    public class Users
    {
        public int Seq { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
