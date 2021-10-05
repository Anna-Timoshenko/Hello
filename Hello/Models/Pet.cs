using Softeq.XToolkit.Common;

namespace Hello.Models
{
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
