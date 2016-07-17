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
    public class ServiceBase<TEntity>
        : IServiceBase<TEntity>
        where TEntity : EntityBase
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this._repository = repository;
        }

        public TEntity Add(TEntity obj)
        {
            return _repository.Add(obj);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Remove(int objId)
        {
            _repository.Remove(objId);
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<TEntity> GetAllActive()
        {
            return _repository.GetAllActive();
        }

        public TEntity GetById(int objId)
        {
            return _repository.GetById(objId);
        }

        public void RemoveAll(IEnumerable<TEntity> obj)
        {
            _repository.RemoveAll(obj);
        }

        public void AddOrUpdate(TEntity obj)
        {
            _repository.AddOrUpdate(obj);
        }

        public TEntity First()
        {
            return _repository.First();
        }

        public int CountAll()
        {
            return _repository.CountAll();
        }

        public int CountAllActive()
        {
            return _repository.CountAllActive();
        }
    }
}
