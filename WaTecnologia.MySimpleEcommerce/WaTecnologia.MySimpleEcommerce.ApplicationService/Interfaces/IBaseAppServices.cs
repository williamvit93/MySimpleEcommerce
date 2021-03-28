using System.Collections.Generic;

namespace WaTecnologia.MySimpleEcommerce.ApplicationService.Interfaces
{
    public interface IBaseAppServices<TEntity, TEntityViewModel>
        where TEntity : class
        where TEntityViewModel : class
    {
        void Add(TEntityViewModel entity);
        void Update(TEntityViewModel entity);
        void Dispose();
        TEntityViewModel GetById(int id);
        void Delete(int id);
        IEnumerable<TEntityViewModel> GetAll();
    }
}
