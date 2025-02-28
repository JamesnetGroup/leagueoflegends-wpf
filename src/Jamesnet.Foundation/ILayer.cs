using System.Windows;

namespace Jamesnet.Foundation;

public interface ILayer
{
    object Content { get; set; }
    string LayerName { get; set; }
    bool IsRegistered { get; set; }
}
