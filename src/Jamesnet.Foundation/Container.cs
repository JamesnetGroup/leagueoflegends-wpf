using System;
using System.Collections.Generic;
using System.Linq;

namespace Jamesnet.Foundation;

public class Container : IContainer
{
    private readonly Dictionary<(Type, string), Func<object>> _registrations = new Dictionary<(Type, string), Func<object>>();

    public void Register<TInterface, TImplementation>() where TImplementation : TInterface
    {
        Register<TInterface, TImplementation>(null);
    }

    public void Register<TInterface, TImplementation>(string name) where TImplementation : TInterface
    {
        _registrations[(typeof(TInterface), name)] = () => CreateInstance(typeof(TImplementation));
    }

    public void RegisterSingleton<TInterface, TImplementation>() where TImplementation : TInterface
    {
        RegisterSingleton<TInterface, TImplementation>(null);
    }

    public void RegisterSingleton<TInterface, TImplementation>(string name) where TImplementation : TInterface
    {
        var lazy = new Lazy<object>(() => CreateInstance(typeof(TImplementation)));
        _registrations[(typeof(TInterface), name)] = () => lazy.Value;
    }

    public void RegisterSingleton<TImplementation>(string name)
    {
        var lazy = new Lazy<object>(() => CreateInstance(typeof(TImplementation)));
        _registrations[(typeof(TImplementation), name)] = () => lazy.Value;
    }

    public void RegisterInstance<TInterface>(TInterface instance)
    {
        RegisterInstance(instance, null);
    }

    public void RegisterInstance<TInterface>(TInterface instance, string name)
    {
        _registrations[(typeof(TInterface), name)] = () => instance;
    }

    public T Resolve<T>()
    {
        return Resolve<T>(null);
    }

    public T Resolve<T>(string name)
    {
        return (T)Resolve(typeof(T), name);
    }

    public object Resolve(Type type)
    {
        return Resolve(type, null);
    }

    public object Resolve(Type type, string name)
    {
        if (_registrations.TryGetValue((type, name), out var creator))
        {
            return creator();
        }
        if (!type.IsAbstract && !type.IsInterface)
        {
            return CreateInstance(type);
        }
        throw new InvalidOperationException($"Type {type} has not been registered.");
    }

    public bool TryResolve<T>(out T result)
    {
        return TryResolve<T>(null, out result);
    }

    public bool TryResolve<T>(string name, out T result)
    {
        if (_registrations.TryGetValue((typeof(T), name), out var creator))
        {
            result = (T)creator();
            return true;
        }
        if (!typeof(T).IsAbstract && !typeof(T).IsInterface)
        {
            result = (T)CreateInstance(typeof(T));
            return true;
        }
        result = default;
        return false;
    }


    private object CreateInstance(Type type)
    {
        var constructors = type.GetConstructors();
        var constructor = constructors.FirstOrDefault(c => c.GetParameters().Length > 0) ?? constructors.First();
        var parameters = constructor.GetParameters().Select(p => Resolve(p.ParameterType)).ToArray();
        var instance = constructor.Invoke(parameters);
        if (instance is IView view)
        {
            var initializer = Resolve<IViewModelInitializer>();
            initializer.InitializeViewModel(view);
            var viewModelInitialized = view.DataContext != null;
            var loadedEvent = type.GetEvent("Loaded");
            if (loadedEvent != null)
            {
                // 델리게이트를 Action으로 변환
                Action<object, object> handler = null;
                handler = (s, e) =>
                {
                    if (viewModelInitialized && view.DataContext is IViewFirstLoadable loadable)
                    {
                        loadable.FirstLoaded(view);
                    }
                    // 이벤트 제거를 위한 델리게이트 생성
                    var delegateType = loadedEvent.EventHandlerType;
                    var removeHandler = Delegate.CreateDelegate(delegateType, (object)handler.Target, handler.Method);
                    loadedEvent.RemoveEventHandler(view, removeHandler);
                };

                // 매번 실행되는 Loaded 이벤트 핸들러
                Action<object, object> loadHandler = (s, e) =>
                {
                    if (viewModelInitialized && view.DataContext is IViewLoadable loadable)
                    {
                        loadable.Loaded(view);
                    }
                };

                // 이벤트 추가를 위한 델리게이트 생성
                var addHandler = Delegate.CreateDelegate(loadedEvent.EventHandlerType, (object)handler.Target, handler.Method);
                var loadDelegate = Delegate.CreateDelegate(loadedEvent.EventHandlerType, (object)loadHandler.Target, loadHandler.Method);

                loadedEvent.AddEventHandler(view, addHandler);
                loadedEvent.AddEventHandler(view, loadDelegate);
            }
        }
        return instance;
    }
}
