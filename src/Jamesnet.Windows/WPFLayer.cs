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

    static WPFLayer()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(WPFLayer), new FrameworkPropertyMetadata(typeof(WPFLayer)));
    }
    public WPFLayer()
    {
        Loaded += UnoLayer_Loaded;
    }

    protected override void OnContentChanged(object oldContent, object newContent)
    {
        base.OnContentChanged(oldContent, newContent);
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
        try
        {
            if (d is WPFLayer layer)
            {
                layer._isRegistered = false;
                layer.RegisterToLayerManager();
            }
        }
        catch
        {

        }
    }
}
