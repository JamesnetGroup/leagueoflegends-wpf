using System.Windows.Input;
using DevNcore.LayoutSupport.Leagueoflegends.Controls.Primitives;
using DevNcore.UI.Foundation.Mvvm;
using Lol.Settings.InGame.UI.Units;
using wf = System.Windows.Forms;

namespace Lol.Settings.InGame.Local.ViewModels
{
    public class ReplayViewModel : ObservableObject
    {
        #region ReplayPath

        public string ReplayPath { get; set; }
        #endregion

        #region HighlightPath

        public string HighlightPath { get; set; }
        #endregion

        #region ICommand

        public ICommand FindCommand { get; set; }
        #endregion

        #region Constructor

        public ReplayViewModel()
        {
            FindCommand = new RelayCommand<object>(ChangePath);
            ReplayPath = RiotApp.REPLAY_PATH;
            HighlightPath = RiotApp.HIGHLIGHT_PATH;
        }
        #endregion

        #region ChangePath

        private void ChangePath(object obj)
        {
            if (obj is FindButton btn)
            {
                // TODO: [James] 윈폼 DLL을 사용하지 않고도 해결 방법이 있는지 확인 필요.
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
