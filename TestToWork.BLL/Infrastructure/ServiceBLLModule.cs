using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestToWork.DAL.Interfaces;
using TestToWork.DAL.Repositories;

namespace TestToWork.BLL.Infrastructure
{
    public class ServiceBLLModule : NinjectModule
    {
        private string connectionString;
        public ServiceBLLModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
