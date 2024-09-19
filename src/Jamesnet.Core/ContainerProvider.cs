using System;

namespace Jamesnet.Core;

public static class ContainerProvider
{
    private static IContainer _container;

    public static void SetContainer(IContainer container)
    {
        _container = container;
    }

    public static IContainer GetContainer()
    {
        if (_container == null)
        {
            throw new InvalidOperationException("IContainer has not been set. Make sure to call ContainerProvider.SetContainer in your App class.");
        }
        return _container;
    }
}
