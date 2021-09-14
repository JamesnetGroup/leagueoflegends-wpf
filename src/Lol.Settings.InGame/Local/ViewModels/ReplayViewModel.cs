using Lol.Foundation.Mvvm;
using Lol.Foundation.Riotbase;
using Lol.Settings.InGame.UI.Units;
using System.Windows.Input;
using wf = System.Windows.Forms;

namespace Lol.Settings.InGame.Local.ViewModels
{
    public class ReplayViewModel : ObservableObject
    {
        #region ReplayPath

        public string ReplayPath => RiotApp.REPLAY_PATH;
        #endregion

        #region HighlightPath

        public string HighlightPath => RiotApp.HIGHLIGHT_PATH;
        #endregion

        #region ICommand

        public ICommand FindCommand { get; set; }
        #endregion

        #region Constructor

        public ReplayViewModel()
        {
            FindCommand = new RelayCommand<object>(ChangePath);
        }
        #endregion

        #region ChangePath

        private void ChangePath(object obj)
        {
            if (obj is FindButton btn)
            {
                wf.FolderBrowserDialog folderBrowser = new()
                {
                    SelectedPath = btn.SavePath
                };

                if (folderBrowser.ShowDialog() == wf.DialogResult.OK)
                {
                    btn.SavePath = folderBrowser.SelectedPath;
                }
            }
        }
        #endregion
    }
}
