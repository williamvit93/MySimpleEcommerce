using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WaTecnologia.MySimpleEcommerce.Repository.Repositories.Interfaces;

namespace WaTecnologia.MySimpleEcommerce.Repository.Repositories
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly MySimpleEcommerceContext _db;

        public BaseRepository()
        {
            _db = new MySimpleEcommerceContext();
        }

        public void Add(TEntity entity)
        {
            _db.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            _db.Remove(entity);
            _db.SaveChanges();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _db.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            //_db.Entry(entity).Property("CreatedDate").IsModified = false;
            _db.SaveChanges();
        }
    }
}
