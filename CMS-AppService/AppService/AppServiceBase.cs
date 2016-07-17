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
    public class AppServiceBase<TEntity>
        : IAppServiceBase<TEntity>
        where TEntity : EntityBase
    {
        private readonly IServiceBase<TEntity> _service;

        public AppServiceBase(IServiceBase<TEntity> service)
        {
            this._service = service;
        }

        public TEntity Add(TEntity obj)
        {
            return _service.Add(obj);
        }

        public void Remove(TEntity obj)
        {
            _service.Remove(obj);
        }

        public void Remove(int objId)
        {
            _service.Remove(objId);
        }

        public void Update(TEntity obj)
        {
            _service.Update(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _service.GetAll();
        }

        public IEnumerable<TEntity> GetAllActive()
        {
            return _service.GetAllActive();
        }

        public TEntity GetById(int objId)
        {
            return _service.GetById(objId);
        }

        public void RemoveAll(IEnumerable<TEntity> obj)
        {
            _service.RemoveAll(obj);
        }

        public void AddOrUpdate(TEntity obj)
        {
            _service.AddOrUpdate(obj);
        }

        public TEntity First()
        {
            return _service.First();
        }

        public int CountAll()
        {
            return _service.CountAll();
        }

        public int CountAllActive()
        {
            return CountAllActive();
        }
    }
}
