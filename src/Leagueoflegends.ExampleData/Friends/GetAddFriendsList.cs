using Leagueoflegends.Data.Local.Schema;
using Leagueoflegends.Data.Main;
using Leagueoflegends.ExampleData.Local;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Leagueoflegends.ExampleData.Friends
{
	public partial class ExamFriends
    {
        public static List<UsersTable> GetAddFriendsList()
        {
            IDeserializer deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            string path1 = @"..\..\..\Leagueoflegends.ExampleData\Local\Database\users.yaml";
            var friends = deserializer.Deserialize<List<UsersTable>>(File.ReadAllText(path1));

			RandomHelper.Shuffle(friends);

            ISerializer serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            return friends.Take(15).ToList();
        }
    }
}
