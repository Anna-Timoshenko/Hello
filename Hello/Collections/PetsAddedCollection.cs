using Hello.Models;
using System.Collections.Generic;

namespace Hello.Collections
{
    public static class PetsAddedCollection
    {
        static public List<PetViewModel> PetsAdded = new List<PetViewModel>
        {
            new PetViewModel("Eva", "#fee04d"),
            new PetViewModel("Richard", "#bbf667")
        };

        static public List<PetViewModel> Pets = new List<PetViewModel>
        {
            new PetViewModel("Emma", "#ba7eff"),
            new PetViewModel("Craig", "#e635e6"),
            new PetViewModel("Celvin", "#ff9300"),
            new PetViewModel("Bim", "#fee04d"),
            new PetViewModel("Rex", "#bbf667")
        };
    }
}
