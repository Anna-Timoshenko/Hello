using Foundation;
using Softeq.XToolkit.WhiteLabel.Bootstrapper;
using Softeq.XToolkit.WhiteLabel.Bootstrapper.Abstract;
using Softeq.XToolkit.WhiteLabel.iOS;
using Softeq.XToolkit.WhiteLabel.Navigation;
using UIKit;

namespace HelloIOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : AppDelegateBase
    {
        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            var result = base.FinishedLaunching(application, launchOptions);

            // Override point for customization after application launch.

            return result;
        }

        protected override IBootstrapper CreateBootstrapper()
        {
            return new CustomIosBootstrapper();
        }

        protected override void InitializeNavigation(IContainer container)
        {

        }
    }
}

