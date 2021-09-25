using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.YamlDatabase.Entites.Schema
{
    public class RequestUsers : Users
    {
        public bool IsSent { get; set; }

        public RequestUsers(Users user)
        {
            Seq = user.Seq;
            Name = user.Name;
            Created = user.Created;
            Updated = user.Updated;
        }
    }
}
