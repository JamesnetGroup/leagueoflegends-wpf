using Jamesnet.Core;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;

namespace Jamesnet.Windows;

public class WPFLayer : ContentControl, ILayer
{
    public static readonly DependencyProperty LayerNameProperty =
        DependencyProperty.Register(nameof(LayerName), typeof(string), typeof(WPFLayer), new PropertyMetadata(null, OnLayerNameChanged));

    private bool _isRegistered = false;

    public string LayerName
    {
        get => (string)GetValue(LayerNameProperty);
        set => SetValue(LayerNameProperty, value);
    }

    public WPFLayer()
    {
        Loaded += UnoLayer_Loaded;
    }

    private void UnoLayer_Loaded(object sender, RoutedEventArgs e)
    {
        RegisterToLayerManager();
    }

    private void RegisterToLayerManager()
    {
        if (string.IsNullOrEmpty(LayerName) || _isRegistered)
        {
            return;
        }

        var layerManager = ContainerProvider.GetContainer().Resolve<ILayerManager>();
        if (layerManager != null)
        {
            layerManager.Register(LayerName, this);
            _isRegistered = true;
        }
    }

    private static void OnLayerNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is WPFLayer layer)
        {
            layer._isRegistered = false;  // Reset registration status when LayerName changes
            layer.RegisterToLayerManager();
        }
    }
}
