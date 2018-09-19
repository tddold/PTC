using PTC.Web.Constants;
using PTC.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PTC.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Register only one View Engines to up of performens rendering view
            ViewEnginesConfiguration.RegisterViewEngines(ViewEngines.Engines);
           

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            AutoMapperConfig.RegisterMappings(
                Assembly.Load(AssemblyConstants.Web),
                Assembly.Load(AssemblyConstants.WebInfrastructure));
        }
    }
}
