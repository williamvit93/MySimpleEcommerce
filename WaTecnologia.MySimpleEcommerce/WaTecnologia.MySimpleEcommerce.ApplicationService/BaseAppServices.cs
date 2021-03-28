using AutoMapper;
using System.Collections.Generic;
using WaTecnologia.MySimpleEcommerce.ApplicationService.Interfaces;
using WaTecnologia.MySimpleEcommerce.Repository.Repositories.Interfaces;

namespace WaTecnologia.MySimpleEcommerce.ApplicationService
{
    public class BaseAppServices<TEntity, TEntityViewModel> : IBaseAppServices<TEntity, TEntityViewModel> 
        where TEntity: class
        where TEntityViewModel: class
    {
        private readonly IBaseRepository<TEntity> _baseRepository;
        private readonly IMapper _mapper;
        public BaseAppServices(IMapper mapper, IBaseRepository<TEntity> baseRepository)
        {
            _mapper = mapper;
            _baseRepository = baseRepository;
        }
        public void Add(TEntityViewModel entityViewModel)
        {
            var entity = _mapper.Map<TEntity>(entityViewModel);
            _baseRepository.Add(entity);
        }

        public void Delete(int id)
        {
            _baseRepository.Delete(id);
        }

        public void Dispose()
        {
            _baseRepository.Dispose();
        }

        public IEnumerable<TEntityViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<TEntityViewModel>>(_baseRepository.GetAll());
        }

        public TEntityViewModel GetById(int id)
        {
            return _mapper.Map<TEntityViewModel>(_baseRepository.GetById(id));
        }

        public void Update(TEntityViewModel entityViewModel)
        {
            var entity = _mapper.Map<TEntity>(entityViewModel);
            _baseRepository.Update(entity);
        }
    }
}
