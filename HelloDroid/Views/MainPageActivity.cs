using System;
using Android.App;
using Android.OS;
using Android.Widget;
using Hello.ViewModels;
using Softeq.XToolkit.Bindings.Extensions;
using Softeq.XToolkit.WhiteLabel.Droid;

namespace HelloDroid.Views
{
    [Activity]
    public class MainPageActivity : ActivityBase<MainPageViewModel>
    {
        private TextView? _textHello;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            _textHello = FindViewById<TextView>(Resource.Id.Text);

            this.Bind(() => ViewModel.HelloText, () => _textHello.Text);
        }
    }
}
