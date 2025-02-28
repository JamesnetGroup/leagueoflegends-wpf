using System;

namespace Jamesnet.Foundation;

public interface IViewModelMapper
{
    void Register<TView, TViewModel>() where TView : IView where TViewModel : class;
    Type GetViewModelType(Type viewType);
}
