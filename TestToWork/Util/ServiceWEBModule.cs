using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestToWork.BLL.Interfaces;
using TestToWork.BLL.Services;

namespace TestToWork.Util
{
    public class ServiceWEBModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IServices>().To<Services>();
        }
    }
}