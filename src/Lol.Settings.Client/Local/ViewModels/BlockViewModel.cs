using Lol.Foundation.Mvvm;
using Lol.LayoutSupport.Controls;
using System.Windows.Input;

namespace Lol.Settings.Client.Local.ViewModels
{
	public class BlockViewModel : ObservableObject
	{
		#region ICommand

		public ICommand KeywordCommand { get; private set; }
		public ICommand CloseKeywordCommand { get; private set; }
		#endregion

		#region Keyword

		private string _keyword;
		public string Keyword
		{
			get { return _keyword; }
			set { _keyword = value; OnPropertyChanged(); }
		}
		#endregion

		#region Constructor
		public BlockViewModel()
		{
			Keyword = "";
			KeywordCommand = new RelayCommand<object>(KeywordChanged);
			CloseKeywordCommand = new RelayCommand<object>(CloseKeyword);
		}
		#endregion

		#region KeywordChanged

		private void KeywordChanged(object obj)
		{
			Keyword = (obj as RiotTextBox).Text;
		}
		#endregion

		#region CloseKeyword

		private void CloseKeyword(object obj)
		{
			Keyword = "";
		}
		#endregion
	}
}
