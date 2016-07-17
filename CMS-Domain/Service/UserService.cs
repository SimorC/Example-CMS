using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS_Domain.Entity;
using CMS_Domain.Interfaces.Repository;
using CMS_Domain.Interfaces.Service;

namespace CMS_Domain.Service
{
    public class UserService : ServiceBase<User>, IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
            : base(repository)
        {
            _repository = repository;
        }

        public User DoLogin(User user)
        {
            return _repository.DoLogin(user);
        }
    }
}
