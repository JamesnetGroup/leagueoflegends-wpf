using System;

namespace Jamesnet.Core;

public interface IViewModelMapper
{
    void Register<TView, TViewModel>() where TView : IView where TViewModel : class;
    Type GetViewModelType(Type viewType);
}
