using System;
using System.ComponentModel.DataAnnotations;

namespace Leagueoflegends.DBEntity.Local.Entities.Schema
{
    public class Users
    {
        [Key]
        public int Seq { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
