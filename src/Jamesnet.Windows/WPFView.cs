using Jamesnet.Core;
using System.Windows.Controls;
using System.Windows;

namespace Jamesnet.Windows;

public class WPFView : ContentControl, IView
{
    private bool _viewModelInitialized = false;

    public WPFView()
    {
        InitializeViewModel();
        Loaded += OnLoaded;
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        if (_viewModelInitialized && DataContext is IViewLoadable loadable)
        {
            loadable.Loaded();
        }
        Loaded -= OnLoaded;
    }

    public void InitializeViewModel()
    {
        var initializer = ContainerProvider.GetContainer().Resolve<IViewModelInitializer>();
        initializer.InitializeViewModel(this);

        _viewModelInitialized = DataContext != null;

        OnViewModelInitialized();
    }

    protected virtual void OnViewModelInitialized()
    {
    }
}
