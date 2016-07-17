using CMS_Domain.Entity;

namespace CMS_Domain.Interfaces.Repository
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        User DoLogin(User user);
    }
}