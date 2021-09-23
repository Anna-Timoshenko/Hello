using System;
using Android.App;
using Android.OS;
using AndroidX.RecyclerView.Widget;
using Hello.ViewModels;
using Hello.Models;
using Softeq.XToolkit.WhiteLabel.Droid;
using HelloDroid.Views.Adapters;
using System.Collections.Generic;
using Android.Graphics;

namespace HelloDroid.Views
{
    [Activity(
    MainLauncher = true,
    NoHistory = true)]
    public class AddCollarPairActivity : ActivityBase<AddCollarPairViewModel>
    {
        private RecyclerView? _recyclerView;
        private DogAdapter _dogAdapter;
        private List<Dog> _dogs;
        public AddCollarPairActivity()
        {
            _dogs = new List<Dog>
            {
                new Dog("Eva", Color.Black),
                new Dog("Richard", Color.Yellow)
            };
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_add_collar_pair);

            _recyclerView = FindViewById<RecyclerView>(Resource.Id.activity_add_collar_pair_recyclerView);

            _dogAdapter = new DogAdapter(_dogs);

            _recyclerView.SetAdapter(_dogAdapter);
            _recyclerView.SetLayoutManager(new LinearLayoutManager(this));
        }
    }
}
