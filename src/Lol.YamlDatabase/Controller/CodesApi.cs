using Lol.YamlDatabase.Entites.Schema;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Lol.YamlDatabase.Controller
{
    public class CodesApi
    {
        public List<UsualCodes> GetCodes(string codeId)
        {
            var items = GetCodeItems()
                .Where(x => x.CodeId == codeId)
                .OrderBy(x => x.Sort)
                .Select(x => new UsualCodes(x))
                .ToList();

            return items;
        }

        private List<CodeItems> GetCodeItems()
        {
            string file = "/datas/codeitems.yml";
            string path = Environment.CurrentDirectory + file;

            string readText = File.ReadAllText(path);

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            return deserializer.Deserialize<List<CodeItems>>(readText);
        }
    }
}
