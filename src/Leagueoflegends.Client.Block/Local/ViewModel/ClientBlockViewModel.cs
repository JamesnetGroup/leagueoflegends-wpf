using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.LayoutSupport.Controls;
using System.Windows.Input;

namespace Leagueoflegends.Client.Block.Local.ViewModel
{
	public class ClientBlockViewModel : ObservableObject
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
        public ClientBlockViewModel()
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
