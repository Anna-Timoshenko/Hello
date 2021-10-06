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
        private bool _checkSwitch;
        private int _counter;
        private string _textSwitch;
        private string _textOutput;
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

        public ICommand IncrementCommand { get; }
        public ICommand DecrementCommand { get; }
        public ICommand NavigateCommandBack { get; }
        public string Title => "Dymanic page";

        public string TextSwitch
        {
            get => _internalSettings.GetValueOrDefault("TextSwitch", "ON");
            private set
            {
                _internalSettings.AddOrUpdateValue("TextSwitch", value);
                Set(ref _textSwitch, value);
            }
        }

        public bool CheckSwitch
        {
            get => _internalSettings.GetValueOrDefault("CheckSwitch", true);
            set
            {
                _internalSettings.AddOrUpdateValue("CheckSwitch", value);
                Set(ref _checkSwitch, value);
                ChangeTextSwitch(value);
            }
        }

        public int Counter
        {
            get => _internalSettings.GetValueOrDefault("Counter", 100);
            private set
            {
                _internalSettings.AddOrUpdateValue("Counter", value);
                Set(ref _counter, value);
            }
        }

        public string TextOutput
        {
            get => _internalSettings.GetValueOrDefault("TextOutput", string.Empty);
            private set
            {
                var textReverse = ReverseText(value);
                _internalSettings.AddOrUpdateValue("TextOutput", textReverse);
                Set(ref _textOutput, ReverseText(textReverse));
            }
        }

        private void ChangeTextSwitch(bool check)
        {
            TextSwitch = check ? "ON" : "OFF";
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
