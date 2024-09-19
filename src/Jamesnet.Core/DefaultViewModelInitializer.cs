using System;
using System.Linq;

namespace Jamesnet.Core;

public class DefaultViewModelInitializer : IViewModelInitializer
{
    private readonly IContainer _container;
    private readonly IViewModelMapper _viewModelMapper;

    public DefaultViewModelInitializer(IContainer container, IViewModelMapper viewModelMapper)
    {
        _container = container;
        _viewModelMapper = viewModelMapper;
    }

    public void InitializeViewModel(IView view)
    {
        var viewType = view.GetType();
        var viewModelType = _viewModelMapper.GetViewModelType(viewType);

        if (viewModelType != null)
        {
            var viewModel = CreateViewModel(viewModelType);
            view.DataContext = viewModel;
        }
    }

    private object CreateViewModel(Type viewModelType)
    {
        try
        {
            var constructor = viewModelType.GetConstructors()
                .OrderByDescending(c => c.GetParameters().Length)
                .First();

            var parameters = constructor.GetParameters()
                .Select(p => _container.Resolve(p.ParameterType))
                .ToArray();

            return constructor.Invoke(parameters);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Failed to create ViewModel of type {viewModelType.Name}.", ex);
        }
    }

}
