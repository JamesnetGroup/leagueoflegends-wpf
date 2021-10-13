using System;

namespace Lol.YamlDatabase.Entites.Schema
{
    public class ClashSchedules
    {
        public int Seq { get; set; }
        public string? Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime EndDate { get; set; }
    }
}
