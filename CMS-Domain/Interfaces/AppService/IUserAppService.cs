using CMS_Domain.Entity;

namespace CMS_Domain.Interfaces.AppService
{
    public interface IUserAppService : IAppServiceBase<User>
    {
        User DoLogin(User user);
    }
}