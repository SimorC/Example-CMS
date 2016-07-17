using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using CMS_Data.Context;
using CMS_Domain.Entity;
using CMS_Domain.Interfaces.Repository;

namespace CMS_Data.Repositories
{
    public class RepositoryBase<TEntity>
        : IDisposable, IRepositoryBase<TEntity>
        where TEntity : EntityBase
    {
        protected CMSContext Db = new CMSContext();
        private DbSet<TEntity> Entity { get { return Db.Set<TEntity>(); } }

        public TEntity Add(TEntity obj)
        {
            var newEntity = Db.Set<TEntity>().Create();
            Db.Set<TEntity>().Add(newEntity);
            Db.Entry(newEntity).CurrentValues.SetValues(obj);
            Commit();
            return newEntity;
        }

        public void AddAll(IEnumerable<TEntity> obj)
        {
            foreach (var entity in obj)
                Add(entity);
        }

        public TEntity GetById(int id)
        {
            var x = Db.Set<TEntity>().Find(id);
            return x;
        }

        public IQueryable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().OrderBy(t => t.Id);
        }

        public IQueryable<TEntity> GetAllActive()
        {
            return Db.Set<TEntity>().Where(x => x.IsActive)
                .OrderBy(t => t.Id);
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Commit();
        }

        public void Remove(TEntity obj)
        {
            obj.IsActive = false;
            Update(obj);
        }

        public void Remove(int id)
        {
            Remove(GetById(id));
        }

        public void RemoveAll(IEnumerable<TEntity> obj)
        {
            foreach (var entity in obj)
                Remove(entity);
        }

        public void AddOrUpdate(TEntity obj)
        {
            if (obj.Id > 0)
                Update(obj);
            else
                Add(obj);
        }
        public TEntity First()
        {
            return Db.Set<TEntity>().FirstOrDefault();
        }

        public void Commit()
        {
            try
            {
                Db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int CountAll()
        {
            return GetAll().Count();
        }

        public int CountAllActive()
        {
            return GetAll().Count(x => x.IsActive);
        }

        public void Detach(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Detached;
        }
    }
}