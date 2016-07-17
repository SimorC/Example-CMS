using CMS_Domain.Entity;

namespace CMS_Domain.Interfaces.Service
{
    public interface IUserService : IServiceBase<User>
    {
        User DoLogin(User user); 
    }
}