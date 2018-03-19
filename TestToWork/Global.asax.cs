﻿using AutoMapper;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TestToWork.BLL.Infrastructure;
using TestToWork.Util;

namespace TestToWork
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //binding
            NinjectModule seviceWEBModule = new ServiceWEBModule();
            NinjectModule seviceBLLModule = new ServiceBLLModule("ShopsAndProductsContext");
            var kernel = new StandardKernel(seviceWEBModule, seviceBLLModule);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));

            //automapper
            Mapper.Initialize(c => c.AddProfile<AutomapperProfileWEB>());
        }
    }
}
