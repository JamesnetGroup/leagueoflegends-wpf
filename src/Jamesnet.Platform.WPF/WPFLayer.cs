using System.Windows.Controls;
using System.Windows;
using Jamesnet.Foundation;

namespace Jamesnet.Platform.WPF;

public class WPFLayer : ContentControl, ILayer
{
    public static readonly DependencyProperty LayerNameProperty =
        DependencyProperty.Register(nameof(LayerName), typeof(string), typeof(WPFLayer), new PropertyMetadata(null, OnLayerNameChanged));

    public bool IsRegistered { get; set; }

    public string LayerName
    {
        get => (string)GetValue(LayerNameProperty);
        set => SetValue(LayerNameProperty, value);
    }

    public WPFLayer()
    {

        DefaultStyleKey = typeof(WPFLayer);
        if (System.ComponentModel.DesignerProperties.GetIsInDesignMode(this)) return;
        LayerManager.InitializeLayer(this);
    }

    private static void OnLayerNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        try
        {

            if (d is WPFLayer layer)
            {
                layer.IsRegistered = false;
                LayerManager.RegisterToLayerManager(layer);
            }
        }
        catch
        {
        }
    }
}
