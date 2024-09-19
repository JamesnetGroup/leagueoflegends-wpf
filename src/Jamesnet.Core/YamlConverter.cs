using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Jamesnet.Core
{
    public static class YamlConverter
    {
        public static IEnumerable<IReadOnlyDictionary<string, string>> Parse(string content)
        {
            return ParseYamlContent(content);
        }

        public static IEnumerable<IReadOnlyDictionary<string, string>> ParseFile(string filePath)
        {
            string content = File.ReadAllText(filePath);
            return Parse(content);
        }

        public static IEnumerable<IReadOnlyDictionary<string, string>> ParseResource(Assembly assembly, string resourcePath)
        {
            using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
            using (StreamReader reader = new StreamReader(stream))
            {
                string content = reader.ReadToEnd();
                return Parse(content);
            }
        }

        private static IEnumerable<IReadOnlyDictionary<string, string>> ParseYamlContent(string content)
        {
            var lines = content.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None)
                .Where(line => !string.IsNullOrWhiteSpace(line) && !line.TrimStart().StartsWith("#"));

            var currentItem = new Dictionary<string, string>();
            foreach (var line in lines)
            {
                if (line.TrimStart().StartsWith("-"))
                {
                    if (currentItem.Count > 0)
                    {
                        yield return currentItem;
                        currentItem = new Dictionary<string, string>();
                    }
                }

                if (line.Contains(':'))
                {
                    var parts = line.Split(new[] { ':' }, 2);
                    var key = parts[0].Trim().TrimStart('-', ' ');
                    var value = parts[1].Trim();
                    currentItem[key] = value;
                }
            }

            if (currentItem.Count > 0)
            {
                yield return currentItem;
            }
        }
    }
}
