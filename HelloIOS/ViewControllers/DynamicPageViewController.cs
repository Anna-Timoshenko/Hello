using System;
using Hello;
using Hello.ViewModels;
using Softeq.XToolkit.Bindings;
using Softeq.XToolkit.Bindings.Extensions;
using Softeq.XToolkit.WhiteLabel.iOS;

namespace HelloIOS.ViewControllers
{
    public partial class DynamicPageViewController : ViewControllerBase<DynamicViewModel>
    {
        private const int MaxLenghtTextInput = 20;

        public DynamicPageViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ButtonMinus.SetCommand(ViewModel.DecrementCommand);
            ButtonPlus.SetCommand(ViewModel.IncrementCommand);

            NavigationBarView.SetTitle(ViewModel.Title);
            NavigationBarView.SetButtonClose(ViewModel.NavigateCommandBack);

            TextInput.ShouldChangeCharacters = (textField, range, replacementString) =>
            {
                var newLength = textField.Text.Length + replacementString.Length - range.Length;
                return newLength <= MaxLenghtTextInput;
            };
        }

        protected override void DoAttachBindings()
        {
            base.DoAttachBindings();

            this.Bind(() => ViewModel.CheckSwitch, () => Switch.On, BindingMode.TwoWay);
            this.Bind(() => ViewModel.TextSwitch, () => TextSwitch.Text);
            this.Bind(() => ViewModel.Counter, () => Counter.Text, IntToStringConverter.Instance);
            this.Bind(() => ViewModel.TextOutput, () => TextOutput.Text);
            this.Bind(() => ViewModel.TextInput, () => TextInput.Text, BindingMode.TwoWay);
        }
    }
}