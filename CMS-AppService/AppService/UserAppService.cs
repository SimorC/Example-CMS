using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS_Domain.Entity;
using CMS_Domain.Interfaces.AppService;
using CMS_Domain.Interfaces.Service;

namespace CMS_AppService.AppService
{
    public class UserAppService : AppServiceBase<User>, IUserAppService
    {
        private readonly IUserService _service;

        public UserAppService(IUserService service)
            : base(service)
        {
            this._service = service;
        }

        public User DoLogin(User user)
        {
            return _service.DoLogin(user);
        }
    }
}
