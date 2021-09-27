using Android.App;
using Android.OS;
using AndroidX.RecyclerView.Widget;
using Hello.ViewModels;
using Hello.Models;
using Softeq.XToolkit.WhiteLabel.Droid;
using Softeq.XToolkit.Bindings.Droid.Bindable;
using HelloDroid.Views.Collections;
using Android.Widget;
using Softeq.XToolkit.Bindings;

namespace HelloDroid.Views
{
    [Activity]
    public class AddCollarPairActivity : ActivityBase<AddCollarPairViewModel>
    {
        private RecyclerView? _recyclerViewAdded;
        private RecyclerView? _recyclerViewDogs;
        private TextView? _title;
        private TextView? _textChoose;
        private TextView? _textWithCollars;
        private ImageButton? _imageButtonClose;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_add_collar_pair);

            _title = FindViewById<TextView>(Resource.Id.activity_add_collar_pair_textView_title);
            _title.Text = ViewModel.Title;

            _textChoose = FindViewById<TextView>(Resource.Id.activity_add_collar_pair_textView_choose);
            _textChoose.Text = ViewModel.TextChoose;

            _textWithCollars = FindViewById<TextView>(Resource.Id.activity_add_collar_pair_textView_with_color);
            _textWithCollars.Text = ViewModel.TextWitckCollars;

            _imageButtonClose = FindViewById<ImageButton>(Resource.Id.activity_add_collar_pair_imageButton_close);
            _imageButtonClose.SetCommand(ViewModel.NavigateCommandBack);

            _recyclerViewAdded = FindViewById<RecyclerView>(Resource.Id.activity_add_collar_pair_recyclerView_added);
            _recyclerViewAdded.HasFixedSize = false;
            _recyclerViewAdded.SetLayoutManager(new LinearLayoutManager(this));
            var adapterAdded = new BindableRecyclerViewAdapter<PetViewModel, DogCollectionViewHolder>(ViewModel.PetsAdded);
            _recyclerViewAdded.SetAdapter(adapterAdded);

            _recyclerViewDogs = FindViewById<RecyclerView>(Resource.Id.activity_add_collar_pair_recyclerView_pets);
            _recyclerViewDogs.HasFixedSize = true;
            _recyclerViewDogs.SetLayoutManager(new LinearLayoutManager(this));
            var adapterDogs = new BindableRecyclerViewAdapter<PetViewModel, DogCollectionViewHolder>(ViewModel.Pets);
            _recyclerViewDogs.SetAdapter(adapterDogs);
        }
    }
}
