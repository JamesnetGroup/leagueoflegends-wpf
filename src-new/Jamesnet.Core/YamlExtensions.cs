using System;
using System.Collections.Generic;

namespace Jamesnet.Core;

public static class YamlExtensions
{
    public static T GetValue<T>(this IReadOnlyDictionary<string, string> dict, string key, T defaultValue = default)
    {
        if (dict.TryGetValue(key, out string value))
        {
            try
            {
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch
            {
                return defaultValue;
            }
        }
        return defaultValue;
    }
}
