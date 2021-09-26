using Lol.YamlDatabase.Entites.Schema;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Lol.YamlDatabase.Entites.Statics
{
    public class LolDataPack
    {
        internal static LolDataPack Instance;

        static LolDataPack()
        {
            Instance = new LolDataPack();
        }

        private List<Users> _users;
        private List<Friends> _friends;
        internal List<CodeItems> _codeItems;

        internal List<Users> Users
        {
            get
            {
                if (_users == null)
                {
                    string file = "/datas/users.yml";
                    string path = Environment.CurrentDirectory + file;

                    string readText = File.ReadAllText(path);

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _users = deserializer.Deserialize<List<Users>>(readText);
                }
                return _users;
            }
        }

        internal List<Friends> Friends
        {
            get
            {
                if (_friends == null)
                {
                    string file = "/datas/friends.yml";
                    string path = Environment.CurrentDirectory + file;

                    string readText = File.ReadAllText(path);

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _friends = deserializer.Deserialize<List<Friends>>(readText);
                }
                return _friends;
            }
        }

        internal List<CodeItems> CodeItems
        {
            get
            {
                if (_codeItems == null)
                {
                    string file = "/datas/codeitems.yml";
                    string path = Environment.CurrentDirectory + file;

                    string readText = File.ReadAllText(path);

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _codeItems = deserializer.Deserialize<List<CodeItems>>(readText);
                }
                return _codeItems;
            }
        }
    }
}
