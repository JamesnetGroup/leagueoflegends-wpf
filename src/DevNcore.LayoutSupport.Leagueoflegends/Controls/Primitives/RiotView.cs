using DevNcore.UI.Foundation.Mvvm;
using DevNcore.WPF.Controls;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls.Primitives
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
