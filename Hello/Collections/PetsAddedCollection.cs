using Android.Graphics;
using Hello.Models;
using System.Collections.Generic;

namespace Hello.Collections
{
    static public class PetsAddedCollection
    {
        static public List<PetViewModel> PetsAdded = new List<PetViewModel>
        {
            new PetViewModel("Eva", Color.ParseColor("#fee04d")),
            new PetViewModel("Richard", Color.ParseColor("#bbf667"))
        };

        static public List<PetViewModel> Pets = new List<PetViewModel>
        {
            new PetViewModel("Emma", Color.ParseColor("#ba7eff")),
            new PetViewModel("Craig", Color.ParseColor("#e635e6")),
            new PetViewModel("Celvin", Color.ParseColor("#ff9300")),
            new PetViewModel("Bim", Color.ParseColor("#fee04d")),
            new PetViewModel("Rex", Color.ParseColor("#bbf667"))
        };
    }
}
