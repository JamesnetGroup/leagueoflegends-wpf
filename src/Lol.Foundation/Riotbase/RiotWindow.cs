﻿using Lol.Data.Main;
using Lol.Foundation.Mvvm;
using Lol.Foundation.Riotcore;
using System.Windows;

namespace Lol.Foundation.Riotbase
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

            if (DataContext is ObservableObject vm)
            {
                vm.InitRegistUI(this);
            }
        }
        #endregion
    }
}
