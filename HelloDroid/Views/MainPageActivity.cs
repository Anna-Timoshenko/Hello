using Android.App;
using Android.OS;
using Android.Widget;
using Hello.ViewModels;
using Softeq.XToolkit.WhiteLabel.Droid;

namespace HelloDroid.Views
{
    [Activity]
    public class MainPageActivity : ActivityBase<MainPageViewModel>
    {
        private TextView? _textHello;
        private CustomNavigationBarView _navigationBarView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            _textHello = FindViewById<TextView>(Resource.Id.activity_main_textView_hello);
            _textHello.Text = ViewModel.HelloText;

            _navigationBarView = FindViewById<CustomNavigationBarView>(Resource.Id.activity_main_navigation_bar);
            _navigationBarView.SetTitle(ViewModel.Title);
            _navigationBarView.SetButtonClose(ViewModel.NavigateCommandBack);
        }
    }
}
