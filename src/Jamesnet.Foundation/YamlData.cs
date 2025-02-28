using System.Collections.Generic;

namespace Jamesnet.Foundation;

public class YamlData : List<YamlItem>
{
    public YamlData() : base() { }
    public YamlData(IEnumerable<YamlItem> collection) : base(collection) { }
}
