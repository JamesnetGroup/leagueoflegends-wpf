using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotbase;
using Leagueoflegends.Settings.InGame.UI.Units;
using System.Windows.Input;
using wf = System.Windows.Forms;

namespace Leagueoflegends.Settings.InGame.Local.ViewModels
{
	public class ReplayViewModel : ObservableObject
	{
		public string ReplayPath => RiotApp.REPLAY_PATH;
		public string HighlightPath => RiotApp.HIGHLIGHT_PATH;

		#region ICommand

		public ICommand FindCommand { get; set; }
		#endregion

		#region Constructor

		public ReplayViewModel()
		{
			FindCommand = new RelayCommand<object>(ChangePath);
		}
		#endregion

		private void ChangePath(object obj)
		{
			if (obj is FindButton btn)
			{
				wf.FolderBrowserDialog folderBrowser = new wf.FolderBrowserDialog
				{
					SelectedPath = btn.SavePath
				};

				if (folderBrowser.ShowDialog() == wf.DialogResult.OK)
				{
					btn.SavePath = folderBrowser.SelectedPath;
				}
			}
		}
	}
}
