using Android.App;
using Android.OS;
using Android.Widget;
using Hello.ViewModels;
using Softeq.XToolkit.Bindings;
using Softeq.XToolkit.Bindings.Extensions;
using Softeq.XToolkit.WhiteLabel.Droid;
using Hello;
using Google.Android.Material.TextField;
using Android.Views;

namespace HelloDroid.Views
{
    [Activity]
    public class DynamicActivity : ActivityBase<DynamicViewModel>
    {
        private Switch? _switch;
        private TextView? _textSwitch;
        private Button? _buttonPlus;
        private Button? _buttonMinus;
        private TextView? _textCounter;
        private TextView? _textOutput;
        private TextInputEditText? _editTextInput;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_dynamic);

            Window.SetSoftInputMode(SoftInput.StateAlwaysHidden);

            _switch = FindViewById<Switch>(Resource.Id.activity_dynamyc_switch);

            _textSwitch = FindViewById<TextView>(Resource.Id.activity_dynamyc_textView_switch);

            _buttonPlus = FindViewById<Button>(Resource.Id.activity_dynamyc_button_plus);
            _buttonPlus.SetCommand(ViewModel.IncrementCommand);

            _buttonMinus = FindViewById<Button>(Resource.Id.activity_dynamyc_button_minus);
            _buttonMinus.SetCommand(ViewModel.DecrementCommand);

            _textCounter = FindViewById<TextView>(Resource.Id.activity_dynamyc_textView_counter);

            _textOutput = FindViewById<TextView>(Resource.Id.activity_dynamyc_textView_output);

            _editTextInput = FindViewById<TextInputEditText>(Resource.Id.activity_dynamyc_textInputEditText);
        }

        protected override void DoAttachBindings()
        {
            base.DoAttachBindings();

            this.Bind(() => ViewModel.CheckSwitch, () => _switch.Checked, BindingMode.TwoWay);
            this.Bind(() => ViewModel.TextSwitch, () => _textSwitch.Text);
            this.Bind(() => ViewModel.Counter, () => _textCounter!.Text, IntToStringConverter.Instance);
            this.Bind(() => ViewModel.TextOutput, () => _textOutput!.Text);
            this.Bind(() => _editTextInput!.Text, () => ViewModel.TextOutput);
        }
    }
}