using System;
using Android.App;
using Android.Runtime;
using Softeq.XToolkit.WhiteLabel.Bootstrapper;
using Softeq.XToolkit.WhiteLabel.Droid;


namespace HelloDroid
{
    [Application]
    public class MainApplication : MainApplicationBase
    {
        protected MainApplication(IntPtr handle, JniHandleOwnership transer)
            : base(handle, transer)
        {
        }

        protected override IBootstrapper CreateBootstrapper()
        {
            return new CustomDroidBootstrapper();
        }
    }
}
