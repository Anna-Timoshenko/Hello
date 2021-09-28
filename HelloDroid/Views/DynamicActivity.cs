using Android.App;
using Android.OS;
using Android.Widget;
using Hello.ViewModels;
using Softeq.XToolkit.Bindings;
using Softeq.XToolkit.Bindings.Extensions;
using Softeq.XToolkit.WhiteLabel.Droid;

namespace HelloDroid.Views
{
    [Activity]
    public class DynamicActivity : ActivityBase<DynamicViewModel>
    {
        private Switch? _switch;
        private TextView _textSwitch;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_dynamic);

            _switch = FindViewById<Switch>(Resource.Id.activity_dynamyc_switch);
            this.Bind(() => ViewModel.CheckSwitch, () => _switch.Checked, BindingMode.TwoWay);

            _textSwitch = FindViewById<TextView>(Resource.Id.activity_dynamyc_textView_switch);
            this.Bind(() => ViewModel.TextSwitch, () => _textSwitch.Text);
        }
    }
}