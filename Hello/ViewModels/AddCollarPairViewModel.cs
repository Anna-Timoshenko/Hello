using Hello.Collections;
using Hello.Models;
using Softeq.XToolkit.WhiteLabel.Mvvm;
using System.Collections.Generic;

namespace Hello.ViewModels
{
    public class AddCollarPairViewModel : ViewModelBase
    {
        private ICollection<PetViewModel> _dogsAdded;
        private ICollection<PetViewModel> _dogs;

        public AddCollarPairViewModel()
        {
            _dogsAdded = PetsAddedCollection.PetsAdded;
            _dogs = PetsAddedCollection.Pets;
        }

        public ICollection<PetViewModel> DogsAdded { get => _dogsAdded; }
        public ICollection<PetViewModel> Dogs { get => _dogs; }
        public string Title => "Pair Collar With a Pet";
        public string TextChoose => "Please Choose Which Pet Should Use This Collar";
        public string TextWitckCollars => "Pets With Collars";
    }
}
