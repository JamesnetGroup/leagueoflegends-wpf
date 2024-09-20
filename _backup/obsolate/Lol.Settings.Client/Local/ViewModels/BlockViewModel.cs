using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using Jamesnet.Wpf.Mvvm;

namespace Lol.Settings.Client.Local.ViewModels
{
    public partial class BlockViewModel : ObservableBase
    {
        [ObservableProperty]
        private string _keywordStr= "";

        [RelayCommand]
        private void Keyword(object obj)
        {
            KeywordStr = (obj as RiotTextBox).Text;
        }

        [RelayCommand]
        private void CloseKeyword(object obj)
        {
            KeywordStr = "";
        }
    }
}
