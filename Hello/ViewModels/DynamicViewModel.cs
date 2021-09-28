using Softeq.XToolkit.WhiteLabel.Mvvm;
using Softeq.XToolkit.WhiteLabel.Navigation;

namespace Hello.ViewModels
{
    public class DynamicViewModel : ViewModelBase
    {
        private string _textSwitch;
        private readonly IPageNavigationService _pageNavigationService;
        private bool _checkSwitch;

        public DynamicViewModel(IPageNavigationService pageNavigationService)
        {
            _pageNavigationService = pageNavigationService;
            CheckSwitch = true;
        }

        public override void OnInitialize()
        {
            base.OnInitialize();
        }

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
                Set(ref _checkSwitch, value);
                ChangeTextSwitch(value);
            }
        }

        private void ChangeTextSwitch(bool check)
        {
            if (check)
            {
                TextSwitch = "ON";
            }
            else
            {
                TextSwitch = "OFF";
            }
        }
    }
}
