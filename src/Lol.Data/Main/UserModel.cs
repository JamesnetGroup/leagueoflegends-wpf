using System;

namespace Lol.Data.Main
{
    public class UserModel
    {
        public int Seq { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool IsMaintainLogin { get; set; }
        public string MD5 { get; set; }
        public bool Status { get; set; }
        public string StatusMessage { get; set; }
        public int Level { get; set; }
        public int RP { get; set; }
        public int BE { get; set; }
        public DateTime Created { get; set; }
    }
}
