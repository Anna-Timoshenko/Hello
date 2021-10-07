using Softeq.XToolkit.Common.Commands;
using Softeq.XToolkit.Common.Interfaces;
using Softeq.XToolkit.WhiteLabel.Mvvm;
using Softeq.XToolkit.WhiteLabel.Navigation;
using System.Linq;
using System.Windows.Input;

namespace Hello.ViewModels
{
    public class DynamicViewModel : ViewModelBase
    {
        private const string CheckSwitchKey = "CheckSwitch";
        private const string CounterKey = "Counter";
        private const string TextOutputKey = "TextOutput";
        private const string TextInputKey = "TextInput";
        private const string TextSwitchOn = "ON";
        private const string TextSwitchOff = "OFF";
        private const int DefaultCounter = 100;

        private bool _checkSwitch;
        private int _counter;
        private string _textSwitch;
        private string _textOutput;
        private string _textInput;
        private readonly IPageNavigationService _pageNavigationService;
        private readonly IInternalSettings _internalSettings;

        public DynamicViewModel(IPageNavigationService pageNavigationService, IInternalSettings internalSettings)
        {
            _internalSettings = internalSettings;
            _pageNavigationService = pageNavigationService;
            IncrementCommand = new RelayCommand(Increment);
            DecrementCommand = new RelayCommand(Decrement);
            NavigateCommandBack = new RelayCommand(NavigateBack);
        }

        public override void OnInitialize()
        {
            base.OnInitialize();

            CheckSwitch = _internalSettings.GetValueOrDefault(CheckSwitchKey, true);
            Counter = _internalSettings.GetValueOrDefault(CounterKey, DefaultCounter);
            TextOutput = _internalSettings.GetValueOrDefault(TextOutputKey, string.Empty);
            TextInput = _internalSettings.GetValueOrDefault(TextOutputKey, string.Empty);
        }

        public ICommand IncrementCommand { get; }
        public ICommand DecrementCommand { get; }
        public ICommand NavigateCommandBack { get; }
        public string Title => "Dynamic page";

        public string TextSwitch
        {
            get => _textSwitch;
            private set => Set(ref _textSwitch, value);
        }

        public bool CheckSwitch
        {
            get => _checkSwitch;
            set
            {
                _internalSettings.AddOrUpdateValue(CheckSwitchKey, value);
                Set(ref _checkSwitch, value);
                ChangeTextSwitch(value);
            }
        }

        public int Counter
        {
            get => _counter;
            private set
            {
                _internalSettings.AddOrUpdateValue(CounterKey, value);
                Set(ref _counter, value);
            }
        }

        public string TextOutput
        {
            get => _textOutput;
            private set
            {
                _internalSettings.AddOrUpdateValue(TextOutputKey, value);
                Set(ref _textOutput, value);
            }
        }

        public string TextInput
        {
            get => _textInput;
            set
            {
                _internalSettings.AddOrUpdateValue(TextInputKey, value);
                Set(ref _textInput, value);
                TextOutput = ReverseText(value);
            }
        }

        private void ChangeTextSwitch(bool check)
        {
            TextSwitch = check ? TextSwitchOn : TextSwitchOff;
        }

        private void Increment()
        {
            Counter++;
        }

        private void Decrement()
        {
            Counter--;
        }

        private string ReverseText(string text)
        {
            return new string(text.ToCharArray().Reverse().ToArray());
        }

        private void NavigateBack()
        {
            _pageNavigationService.GoBack();
        }
    }
}
