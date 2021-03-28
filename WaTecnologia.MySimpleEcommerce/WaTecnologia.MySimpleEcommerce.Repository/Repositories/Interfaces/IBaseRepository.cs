using System.Collections.Generic;

namespace WaTecnologia.MySimpleEcommerce.Repository.Repositories.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        TEntity GetById(int id);
        void Delete(int id);
        IEnumerable<TEntity> GetAll();
        void Dispose();
    }
}
