using System;
using System.Collections.Generic;
using System.Windows;

namespace Jamesnet.Foundation;

public class LayerManager : ILayerManager
{
    private readonly Dictionary<string, ILayer> _layers = new Dictionary<string, ILayer>();
    private readonly Dictionary<string, List<IView>> _layerViews = new Dictionary<string, List<IView>>();
    private readonly Dictionary<string, IView> _layerViewMappings = new Dictionary<string, IView>();

    public void Register(string layerName, ILayer layer)
    {
        Console.WriteLine($"LayerManager.Register called with layerName: {layerName}");

        if (!_layers.ContainsKey(layerName))
        {
            _layers[layerName] = layer;
            _layerViews[layerName] = new List<IView>();
            if (_layerViewMappings.TryGetValue(layerName, out var view))
            {
                Show(layerName, view);
            }
        }
    }

    public void Show(string layerName, IView view)
    {
        Console.WriteLine($"NavigateContent Show: {layerName} {view}");
        if (!_layers.TryGetValue(layerName, out var layer))
        {
            throw new InvalidOperationException($"Layer not registered: {layerName}");
        }

        if (view == null)
        {
            layer.Content = null;
            Console.WriteLine($"NavigateContent layer.Content is null");
            return;
        }

        if (layer.Content!= null && layer.Content.Equals(view))
        {
            Console.WriteLine($"NavigateContent view is equal");
            if(view.DataContext is IViewLoadable loadable)
            {
                Console.WriteLine($"Loaded");
                loadable.Loaded(view);
            }
            return;
        }

        if (!_layerViews[layerName].Contains(view))
        {
            Add(layerName, view);
        }

        if (layer.Content is IView iview && iview.DataContext is IViewClosed viewClosed)
        {
            viewClosed.ViewClosed(view);
        }

        layer.Content = view as object;
        Console.WriteLine($"Content set to layer {view}");

        if (view.DataContext is IViewActivated activated)
        { 
            activated.ViewActivated(view);
        }
    }

    public void Add(string layerName, IView view)
    {
        if (!_layers.ContainsKey(layerName))
        {
            throw new InvalidOperationException($"Layer not registered: {layerName}");
        }

        if (!_layerViews.ContainsKey(layerName))
        {
            _layerViews[layerName] = new List<IView>();
        }

        if (!_layerViews[layerName].Contains(view))
        {
            _layerViews[layerName].Add(view);
        }
    }

    public void Hide(string layerName)
    {
        if (_layers.TryGetValue(layerName, out var layer))
        {
            layer.Content = null;
        }
    }

    public void Mapping(string layerName, IView view)
    {
        _layerViewMappings[layerName] = view;
    }

    public static void InitializeLayer(ILayer layer)
    {
        if (layer == null)
            throw new ArgumentNullException(nameof(layer));

        var type = layer.GetType();
        var loadedEvent = type.GetEvent("Loaded");
        if (loadedEvent != null)
        {
            Delegate handler = null;

            Action<object, object> handlerAction = (s, e) =>
            {
                RegisterToLayerManager(layer);
                loadedEvent.RemoveEventHandler(layer, handler);
            };

            handler = Delegate.CreateDelegate(loadedEvent.EventHandlerType, handlerAction.Target, handlerAction.Method);

            loadedEvent.AddEventHandler(layer, handler);
        }
        else
        {
            RegisterToLayerManager(layer);
        }
    }


    public static void RegisterToLayerManager(ILayer layer)
    {
        if (string.IsNullOrEmpty(layer.LayerName) || layer.IsRegistered)
        {
            return;
        }

        var layerManager = ContainerProvider.GetContainer().Resolve<ILayerManager>();
        if (layerManager != null)
        {
            layerManager.Register(layer.LayerName, layer);
            layer.IsRegistered = true;
        }
    }

    public ILayer GetLayer(string layerName)
    {
        if (_layers.ContainsKey(layerName))
        { 
            return _layers[layerName];
        }
        return null;
    }
}
