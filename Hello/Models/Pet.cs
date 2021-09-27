using Android.Graphics;
using Softeq.XToolkit.Common;

namespace Hello.Models
{
    public class Pet
    {
        public Pet(string name, Color color)
        {
            Name = name;
            ColorDog = color;
        }

        public string Name { get; set; }
        public Color ColorDog { get; set; }
    }

    public class PetViewModel : ObservableObject
    {
        private string _name = string.Empty;
        private string _color;

        public PetViewModel(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        public string Color
        {
            get => _color;
            set => Set(ref _color, value);
        }
    }
}
