using DevExtremeMvcApp1.Service;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExtremeMvcApp1.Injection
{
    public class NinjectModuleBind : NinjectModule
    {
        public override void Load()
        {
            // Configurer les bindings
            Bind<ICronosService>().To<CronosService>();
        }
    }
}