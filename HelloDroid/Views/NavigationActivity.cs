using Android.App;
using Android.OS;
using Android.Widget;
using Hello.ViewModels;
using Softeq.XToolkit.Bindings;
using Softeq.XToolkit.WhiteLabel.Droid;

namespace HelloDroid.Views
{
    [Activity]
    public class NavigationActivity : ActivityBase<NavigationViewModel>
    {
        private Button? _helloButton;
        private Button? _addCollarButton;
        private Button? _dynamicButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_navigation);

            _helloButton = FindViewById<Button>(Resource.Id.activity_navigation_button_hello);
            _helloButton.SetCommand(ViewModel.NavigateCommandHello);
            _helloButton.Text = ViewModel.TextButtomHello;

            _addCollarButton = FindViewById<Button>(Resource.Id.activity_navigation_button_add_collar);
            _addCollarButton.SetCommand(ViewModel.NavigateCommandAddCollar);
            _addCollarButton.Text = ViewModel.TextButtomAddCollar;

            _dynamicButton = FindViewById<Button>(Resource.Id.activity_navigation_button_dynamic_page);
            _dynamicButton.SetCommand(ViewModel.NavigateCommandDynamic);
            _dynamicButton.Text = ViewModel.TextButtomDynamic;
        }
    }
}