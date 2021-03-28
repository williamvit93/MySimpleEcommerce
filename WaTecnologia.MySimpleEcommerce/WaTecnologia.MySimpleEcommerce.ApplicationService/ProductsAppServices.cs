using AutoMapper;
using WaTecnologia.MySimpleEcommerce.ApplicationService.Interfaces;
using WaTecnologia.MySimpleEcommerce.ApplicationService.ViewModels;
using WaTecnologia.MySimpleEcommerce.Domain.Entities;
using WaTecnologia.MySimpleEcommerce.Repository.Repositories.Interfaces;

namespace WaTecnologia.MySimpleEcommerce.ApplicationService
{
    public class ProductsAppServices : BaseAppServices<Product, ProductViewModel>, IProductsAppServices
    {
        public ProductsAppServices(IMapper mapper, IBaseRepository<Product> baseRepository) : base(mapper, baseRepository)
        {
        }
    }
}
