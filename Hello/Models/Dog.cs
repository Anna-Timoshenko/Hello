using Android.Graphics;
using Softeq.XToolkit.Common;

namespace Hello.Models
{
    public class Dog
    {
        public Dog(string name, Color color)
        {
            Name = name;
            ColorDog = color;
        }

        public string Name { get; set; }
        public Color ColorDog { get; set; }
    }

    public class DogViewModel : ObservableObject
    {
        private string _name = string.Empty;
        private Color _color;

        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        public Color Color
        {
            get => _color;
            set => Set(ref _color, value);
        }

        public DogViewModel(string name, Color color)
        {
            Name = name;
            Color = color;
        }
    }
}
