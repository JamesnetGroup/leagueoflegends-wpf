using System.Collections.Generic;

namespace Jamesnet.Core;

public class YamlData : List<YamlItem>
{
    public YamlData() : base() { }
    public YamlData(IEnumerable<YamlItem> collection) : base(collection) { }
}
