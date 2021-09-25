using Lol.DBEntity.Local.Entities;
using Lol.DBEntity.Local.Entities.Extend;
using Lol.DBEntity.Local.Entities.Implements;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Lol.DBEntity.Local.Api
{
    public class GetFriends
    {
        public List<IFriendsList> Run(int mySeq)
        {
            // TODO: [Elena] Yaml DB 임시 작업중!
            var friends1 = GetFriends1().Where(x=>x.UserSeq == mySeq).ToList();
            var users1 = GetUsers();

            var friends = friends1.Select(x => new MyFriends(users1.First(u => x.FriendsSeq == u.Seq))).ToList()
                .OrderBy(x => x.Status)
                .ToList();

            FriendsHeader general = new("GENERAL", true);
            FriendsHeader offline = new("OFFLINE", true);

            List<IFriendsList> list = new();
            list.Add(general);
            list.Add(offline);

            general.Children.AddRange(friends.Where(x => x.Status > 0));
            offline.Children.AddRange(friends.Where(x => x.Status < 1));

            return list;
        }

        private List<FriendsModel> GetFriends1()
        {
            string file = "/datas/friends.yml";
            string path = Environment.CurrentDirectory + file;

            string readText = File.ReadAllText(path);

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            return deserializer.Deserialize<List<FriendsModel>>(readText);
        }

        private List<UsersModel> GetUsers()
        {
            string file = "/datas/users.yml";
            string path = Environment.CurrentDirectory + file;

            string readText = File.ReadAllText(path);

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            return deserializer.Deserialize<List<UsersModel>>(readText);
        }
    }
    public class UsersModel
    { 
        public int Seq { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
    public class FriendsModel
    {
        public int Seq { get; set; }
        public int UserSeq { get; set; }
        public int FriendsSeq { get; set; }
        public bool IsAccepted { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
