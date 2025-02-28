using Jamesnet.Foundation;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;
using System.Windows.Input;

namespace Leagueoflegends.Collection.Local.ViewModels;

public enum InputMode
{
    VoiceActivity,
    PushToTalk
}

public class VoiceContentViewModel : ViewModelBase, IViewLoadable
{
    private readonly IOptionDataLoader _optionData;
    private List<Option> _inputs;
    private Option _currentInput;
    private InputMode _selectedInputMode;

    public List<Option> Inputs
    {
        get => _inputs;
        set => SetProperty(ref _inputs, value);
    }

    public Option CurrentInput
    {
        get => _currentInput;
        set => SetProperty(ref _currentInput, value);
    }

    public InputMode SelectedInputMode
    {
        get => _selectedInputMode;
        set => SetProperty(ref _selectedInputMode, value);
    }

    public ICommand ChangeInputModeCommand { get; }

    public VoiceContentViewModel(IOptionDataLoader optionData)
    {
        _optionData = optionData;
        ChangeInputModeCommand = new RelayCommand<string>(OnInputModeChanged);
        SelectedInputMode = InputMode.VoiceActivity;
    }

    public void Loaded(object view)
    {
        Inputs = _optionData.GetByCategory("AudioInput");
        CurrentInput = Inputs.FirstOrDefault();
    }

    private void OnInputModeChanged(string mode)
    {
        if (Enum.TryParse(mode, out InputMode inputMode))
        {
            SelectedInputMode = inputMode;
        }
    }
}
