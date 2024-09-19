using System;

namespace Jamesnet.Core;

public interface IContainer
{
    void Register<TInterface, TImplementation>() where TImplementation : TInterface;
    void Register<TInterface, TImplementation>(string name) where TImplementation : TInterface;
    void RegisterSingleton<TInterface, TImplementation>() where TImplementation : TInterface;
    void RegisterSingleton<TInterface, TImplementation>(string name) where TImplementation : TInterface;
    void RegisterSingleton<TImplementation>(string name);
    void RegisterInstance<TInterface>(TInterface instance);
    void RegisterInstance<TInterface>(TInterface instance, string name);
    T Resolve<T>();
    T Resolve<T>(string name);
    object Resolve(Type type);
    object Resolve(Type type, string name);
    bool TryResolve<T>(out T result);
    bool TryResolve<T>(string name, out T result);
}
