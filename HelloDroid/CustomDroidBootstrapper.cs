using System;
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
            builder.Singleton<JsonSerializer, IJsonSerializer>(); // for saving states

            // you can register any dependencies here
        }

        protected override IList<Assembly> SelectAssemblies()
        {
            // for auto-registering ViewModels by Activities
            return base.SelectAssemblies()
                .AddItem(GetType().Assembly);
        }
    }
}
