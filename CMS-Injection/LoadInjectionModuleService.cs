using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS_Data.Repositories;
using CMS_Domain.Interfaces.Repository;
using CMS_Domain.Interfaces.Service;
using CMS_Domain.Service;
using Ninject.Modules;

namespace CMS_Injection
{
    public class LoadInjectionModuleService : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));

            Bind<IUserService>().To<UserService>();
        }
    }
}
