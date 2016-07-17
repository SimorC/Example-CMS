using System.Collections.Generic;
using System.Linq;
using CMS_Domain.Entity;

namespace CMS_Domain.Interfaces.AppService
{
    public interface IAppServiceBase<TEntity> where TEntity : EntityBase
    {
        TEntity Add(TEntity obj);
        void Remove(TEntity obj);
        void Remove(int objId);
        void Update(TEntity obj);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAllActive();
        TEntity GetById(int objId);
        void RemoveAll(IEnumerable<TEntity> obj);
        void AddOrUpdate(TEntity obj);
        TEntity First();
        int CountAll();
        int CountAllActive();
    }
}