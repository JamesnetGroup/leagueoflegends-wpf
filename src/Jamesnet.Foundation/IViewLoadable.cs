namespace Jamesnet.Foundation;

public interface IViewFirstLoadable
{
    void FirstLoaded(object view);
}

public interface IViewLoadable
{
    void Loaded(object view);
}

public interface IViewActivated
{
    void ViewActivated(object view);
}

public interface IViewClosed
{
    void ViewClosed(object view);
}
