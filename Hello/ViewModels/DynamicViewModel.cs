using Softeq.XToolkit.Common.Commands;
using Softeq.XToolkit.WhiteLabel.Mvvm;
using Softeq.XToolkit.WhiteLabel.Navigation;
using System.Linq;
using System.Windows.Input;

namespace Hello.ViewModels
{
    public class DynamicViewModel : ViewModelBase
    {
        private string _textSwitch;
        private readonly IPageNavigationService _pageNavigationService;
        private bool _checkSwitch;
        private int _counter;
        private string _textOutput = string.Empty;

        public DynamicViewModel(IPageNavigationService pageNavigationService)
        {
            _pageNavigationService = pageNavigationService;
            CheckSwitch = true;
            Counter = 100;
            IncrementCommand = new RelayCommand(Increment);
            DecrementCommand = new RelayCommand(Decrement);
        }

        public ICommand IncrementCommand { get; }
        public ICommand DecrementCommand { get; }

        public string TextSwitch
        {
            get => _textSwitch;
            private set => Set(ref _textSwitch, value);
        }

        public bool CheckSwitch
        {
            get => _checkSwitch;
            private set
            {
                Set(ref _checkSwitch, value);
                ChangeTextSwitch(value);
            }
        }

        public int Counter
        {
            get => _counter;
            private set => Set(ref _counter, value);
        }

        public string TextOutput
        {
            get => _textOutput;
            private set => Set(ref _textOutput, ReverseText(value));
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
    }
}
