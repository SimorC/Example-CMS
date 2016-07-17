using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS_Domain.Entity;

namespace CMS_Domain.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        TEntity Add(TEntity obj);
        void Remove(TEntity obj);
        void Remove(int objId);
        void Update(TEntity obj);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAllActive();
        TEntity GetById(int objId);
        void RemoveAll(IEnumerable<TEntity> obj);
        void AddOrUpdate(TEntity obj);
        TEntity First();
        void Commit();
        void Dispose();
        int CountAll();
        int CountAllActive();
        void Detach(TEntity obj);
    }
}
