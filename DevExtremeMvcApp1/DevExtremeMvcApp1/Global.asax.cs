using Ninject.Modules;
using Ninject.Web.Mvc;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DevExtremeMvcApp1.Injection;
using NinjectDependencyResolver = DevExtremeMvcApp1.Injection.NinjectDependencyResolver;

namespace DevExtremeMvcApp1 {

    public class MvcApplication : HttpApplication {

      
        protected void Application_Start() {
            // Créer un noyau Ninject
            IKernel kernel = new StandardKernel();

            // Charger les modules Ninject
            kernel.Load(new INinjectModule[] { new NinjectModuleBind() });

            // Configurer DependencyResolver
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DevExtremeBundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
