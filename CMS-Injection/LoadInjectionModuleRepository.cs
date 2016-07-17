using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS_Data.Repositories;
using CMS_Domain.Interfaces.Repository;
using Ninject.Modules;

namespace CMS_CrossCrossing
{
    public class LoadInjectionModuleRepository : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));

            Bind<IUserRepository>().To<UserRepository>();
        }
    }
}
