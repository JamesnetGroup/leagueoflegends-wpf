namespace Jamesnet.Core;

public interface ILayerManager
{
    void Register(string layerName, ILayer layer);
    void Add(string layerName, IView view);
    void Show(string layerName, IView view);
    void Hide(string layerName);
    void Mapping(string layerName, IView view);
}
