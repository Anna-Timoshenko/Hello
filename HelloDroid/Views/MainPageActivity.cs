using System;
using Android.App;
using Android.OS;
using Hello.ViewModels;
using Softeq.XToolkit.WhiteLabel.Droid;

namespace HelloDroid.Views
{
    [Activity]
    public class MainPageActivity : ActivityBase<MainPageViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);
        }
    }
}
