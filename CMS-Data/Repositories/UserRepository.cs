using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS_Domain.Entity;
using CMS_Domain.Interfaces.Repository;

namespace CMS_Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public User DoLogin(User user)
        {
            return GetAllActive()
                .FirstOrDefault(u => u.Email == user.Email
                                     && u.Password == u.Password);
        }
    }
}
