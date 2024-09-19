using System;
using System.Collections.Generic;

namespace Jamesnet.Core;

public class ViewModelMapper : IViewModelMapper
{
    private readonly Dictionary<Type, Type> _mappings = new Dictionary<Type, Type>();

    public void Register<TView, TViewModel>() where TView : IView where TViewModel : class
    {
        _mappings[typeof(TView)] = typeof(TViewModel);
    }

    public Type GetViewModelType(Type viewType)
    {
        return _mappings.TryGetValue(viewType, out var viewModelType) ? viewModelType : null;
    }
}
