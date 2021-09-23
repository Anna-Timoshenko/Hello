using Android.Views;
using Android.Widget;
using Hello.Models;
using Softeq.XToolkit.Bindings.Droid.Bindable;

namespace HelloDroid.Views.Collections
{
    public class DogCollectionViewHolder : BindableViewHolder<DogViewModel>
    {
        private readonly FrameLayout _color;
        private readonly TextView _name;

        public DogCollectionViewHolder(View view) : base(view)
        {
            _color = view.FindViewById<FrameLayout>(Resource.Id.item_list_dogs_frameLayout);
            _name = view.FindViewById<TextView>(Resource.Id.item_list_dogs_textView_name);
        }

        public FrameLayout ColorDog { get => _color; }
        public TextView Name { get => _name; }
    }
}