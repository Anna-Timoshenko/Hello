using System.Collections.Generic;
using System.Reflection;
using Softeq.XToolkit.Common.Extensions;
using Softeq.XToolkit.Common.Interfaces;
using Softeq.XToolkit.WhiteLabel.Bootstrapper.Abstract;
using Softeq.XToolkit.WhiteLabel.Interfaces;
using Softeq.XToolkit.WhiteLabel.iOS;
using Softeq.XToolkit.WhiteLabel.iOS.Services;
using Softeq.XToolkit.WhiteLabel.Services;

namespace HelloIOS
{
    public class CustomIosBootstrapper : IosBootstrapperBase
    {
        protected override IList<Assembly> SelectAssemblies()
        {
            // for auto-registration ViewModels by ViewControllers
            return base.SelectAssemblies()
                .AddItem(GetType().Assembly);
        }

        protected override void ConfigureIoc(IContainerBuilder builder)
        {
            // you can register any dependencies here

            builder.Singleton<IosAppInfoService, IAppInfoService>();
            builder.Singleton<InternalSettings, IInternalSettings>();
        }
    }
}