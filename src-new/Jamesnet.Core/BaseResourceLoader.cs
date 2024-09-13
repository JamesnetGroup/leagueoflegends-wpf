using System;
using System.Collections.Generic;
using System.Reflection;

namespace Jamesnet.Core;

public abstract class BaseResourceLoader<TItem, TResult>
{
    protected abstract string AssemblyName { get; }
    protected abstract string ResourcePath { get; }
    protected abstract IEnumerable<TItem> ConvertToItems(YamlData rawData);
    protected abstract TResult OrganizeItems(IEnumerable<TItem> items);

    public TResult LoadAndOrganize()
    {
        Assembly assembly = Assembly.Load(AssemblyName);
        YamlData rawData = LoadYamlData(assembly, ResourcePath);
        IEnumerable<TItem> items = ConvertToItems(rawData);
        return OrganizeItems(items);
    }

    private YamlData LoadYamlData(Assembly assembly, string resourcePath)
    {
        YamlData yamlData = new YamlData();

        object result = YamlConverter.ParseResource(assembly, resourcePath);
        IEnumerable<object> data = result as IEnumerable<object>;

        if (data == null)
        {
            throw new InvalidOperationException("YamlConverter.ParseResource did not return an IEnumerable<object>");
        }

        foreach (object item in data)
        {
            IDictionary<string, string> dict = item as IDictionary<string, string>;
            if (dict != null)
            {
                yamlData.Add(new YamlItem(dict));
            }
        }

        return yamlData;
    }
}
