using System.Windows;
using System.Windows.Controls;
using Lol.Data.Main;
using Lol.Foundation.Mvvm;
using Lol.Foundation.Riotcore;

namespace Lol.Foundation.Riotbase
{
    public class RiotView : UserControl, IRiotUI
    {
        #region Constructor

        public RiotView()
        {
            Loaded += RiotView_Loaded;
        }
        #endregion

        #region RiotView_Loaded

        private void RiotView_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is ObservableObject vm)
            {
                vm.InitRegistUI(this);
            }
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
