using Hello.Collections;
using Hello.Models;
using Softeq.XToolkit.Common.Commands;
using Softeq.XToolkit.WhiteLabel.Mvvm;
using Softeq.XToolkit.WhiteLabel.Navigation;
using System.Collections.Generic;
using System.Windows.Input;

namespace Hello.ViewModels
{
    public class AddCollarPairViewModel : ViewModelBase
    {
        private ICollection<PetViewModel> _petsAdded;
        private ICollection<PetViewModel> _pets;
        private readonly IPageNavigationService _pageNavigationService;

        public AddCollarPairViewModel(IPageNavigationService pageNavigationService)
        {
            _petsAdded = PetsAddedCollection.PetsAdded;
            _pets = PetsAddedCollection.Pets;
            _pageNavigationService = pageNavigationService;
            NavigateCommandBack = new RelayCommand(NavigateBack);
        }

        public ICommand NavigateCommandBack { get; }

        public ICollection<PetViewModel> PetsAdded { get => _petsAdded; }
        public ICollection<PetViewModel> Pets { get => _pets; }
        public string Title => "Pair Collar With a Pet";
        public string TextChoose => "Please Choose Which Pet Should Use This Collar";
        public string TextForRightButton => "Done";
        public string TextWitckCollars => "Pets With Collars";

        private void NavigateBack()
        {
            _pageNavigationService.GoBack();
        }
    }
}
