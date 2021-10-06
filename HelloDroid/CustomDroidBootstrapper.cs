using System.Collections.Generic;
using System.Reflection;
using Softeq.XToolkit.Common.Extensions;
using Softeq.XToolkit.Common.Interfaces;
using Softeq.XToolkit.WhiteLabel.Bootstrapper.Abstract;
using Softeq.XToolkit.WhiteLabel.Droid;
using Softeq.XToolkit.WhiteLabel.Services;

namespace HelloDroid
{
    public class CustomDroidBootstrapper : DroidBootstrapperBase
    {
        protected override void ConfigureIoc(IContainerBuilder builder)
        {
            builder.Singleton<JsonSerializer, IJsonSerializer>();
            builder.Singleton<InternalSettings, IInternalSettings>();
        }

        protected override IList<Assembly> SelectAssemblies()
        {
            return base.SelectAssemblies()
                .AddItem(GetType().Assembly);
        }
    }
}
