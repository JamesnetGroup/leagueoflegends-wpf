using System.Windows.Controls;
using DevNcore.UI.Foundation.Mvvm;
using DevNcore.WPF.Controls;
using Lol.Foundation.Riotcore;

namespace Lol.Foundation.Riotbase
{
    public class RiotView : DevNcoreContent, IRiotUI
    {
        #region Constructor

        public RiotView()
        {
        }
        #endregion

        #region SetVM

        public IRiotUI SetVM(ObservableObject vm)
        {
            DataContext = vm;
            return this;
        }
        #endregion
    }
}
