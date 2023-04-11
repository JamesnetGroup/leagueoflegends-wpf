using System.Windows;
using DevNcore.UI.Foundation.Mvvm;

namespace DevNcore.LayoutSupport.Leagueoflegends.Controls.Primitives
{
    public class RiotWindow : Window, IRiotUI
    {
        #region Constructor

        public RiotWindow()
        {
            Loaded += RiotWindow_Loaded;
        }
        #endregion

        #region SetVM

        public IRiotUI SetVM(ObservableObject vm)
        {
            DataContext = vm;
            return this;
        }
        #endregion

        #region RiotWindow_Loaded

        private void RiotWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ResizeMode = ResizeMode.CanMinimize;

            //if (DataContext is ObservableObject vm)
            //{
            //    vm.InitRegistUI(this);
            //}
        }
        #endregion
    }
}
