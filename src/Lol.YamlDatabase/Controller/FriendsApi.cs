using Lol.YamlDatabase.Entites.Schema;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Lol.YamlDatabase.Controller
{
    public class FriendsApi
    {
        public List<IFriendsList> Get(int mySeq)
        {
            // TODO: [Elena] Yaml DB 임시 작업중!
            var friends1 = GetFriends1().Where(x => x.UserSeq == mySeq).ToList();
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

        private List<Friends> GetFriends1()
        {
            string file = "/datas/friends.yml";
            string path = Environment.CurrentDirectory + file;

            string readText = File.ReadAllText(path);

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            return deserializer.Deserialize<List<Friends>>(readText);
        }

        private List<Users> GetUsers()
        {
            string file = "/datas/users.yml";
            string path = Environment.CurrentDirectory + file;

            string readText = File.ReadAllText(path);

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            return deserializer.Deserialize<List<Users>>(readText);
        }
    }
}
