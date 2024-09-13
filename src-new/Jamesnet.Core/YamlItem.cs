using System;
using System.Collections.Generic;

namespace Jamesnet.Core;

public class YamlItem : Dictionary<string, string>
{
    public YamlItem() : base() { }

    public YamlItem(IDictionary<string, string> dictionary) : base(dictionary) { }

    public T GetValue<T>(string key)
    {
        string value;
        if (TryGetValue(key, out value))
        {
            return (T)Convert.ChangeType(value, typeof(T));
        }
        return default(T);
    }
}
