using Android.Graphics.Drawables;
using Android.Views;
using Android.Widget;
using Hello.Models;
using Softeq.XToolkit.Bindings.Droid.Bindable;

namespace HelloDroid.Views.Collections
{
    [BindableViewHolderLayout(Resource.Layout.item_list_pet)]
    public class DogCollectionViewHolder : BindableViewHolder<PetViewModel>
    {
        private readonly View _color;
        private readonly TextView _name;
        private GradientDrawable _drawable;

        public DogCollectionViewHolder(View view) : base(view)
        {
            _color = view.FindViewById<View>(Resource.Id.item_list_pet_view);
            _name = view.FindViewById<TextView>(Resource.Id.item_list_pet_textView_name);

            _color.SetBackgroundResource(Resource.Drawable.roundrect);

            _drawable = (GradientDrawable)_color.Background;
        }

        public override void DoAttachBindings()
        {
            base.DoAttachBindings();

            _drawable.SetColor(ViewModel.Color);
            _name.Text = ViewModel.Name;
        }

        public View ColorDog { get => _color; }
        public TextView Name { get => _name; }
    }
}