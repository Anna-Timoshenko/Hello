using Android.App;
using Android.OS;
using Android.Widget;
using Hello.ViewModels;
using Softeq.XToolkit.Bindings;
using Softeq.XToolkit.WhiteLabel.Droid;

namespace HelloDroid.Views
{
    [Activity]
    public class MainPageActivity : ActivityBase<MainPageViewModel>
    {
        private TextView? _textHello;
        private ImageButton? _imageButtonClose;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            _textHello = FindViewById<TextView>(Resource.Id.activity_main_textView_hello);
            _textHello.Text = ViewModel.HelloText;

            _imageButtonClose = FindViewById<ImageButton>(Resource.Id.activity_add_collar_pair_imageButton_close);
            _imageButtonClose.SetCommand(ViewModel.NavigateCommandBack);
        }
    }
}
