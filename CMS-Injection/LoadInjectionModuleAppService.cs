using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS_AppService.AppService;
using CMS_Domain.Interfaces.AppService;
using CMS_Domain.Interfaces.Service;
using Ninject.Modules;

namespace CMS_Injection
{
    public class LoadInjectionModuleAppService : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));

            Bind<IUserAppService>().To<UserAppService>();
        }
    }
}
