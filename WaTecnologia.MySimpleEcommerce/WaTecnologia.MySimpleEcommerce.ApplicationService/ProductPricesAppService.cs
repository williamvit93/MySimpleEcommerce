using AutoMapper;
using WaTecnologia.MySimpleEcommerce.ApplicationService.Interfaces;
using WaTecnologia.MySimpleEcommerce.ApplicationService.ViewModels;
using WaTecnologia.MySimpleEcommerce.Domain.Entities;
using WaTecnologia.MySimpleEcommerce.Repository.Repositories.Interfaces;

namespace WaTecnologia.MySimpleEcommerce.ApplicationService
{
    public class ProductPricesAppService : BaseAppServices<ProductPrice, ProductPriceViewModel>, IProductPricesAppServices
    {
        public ProductPricesAppService(IMapper mapper, IBaseRepository<ProductPrice> baseRepository) : base(mapper, baseRepository)
        {
        }
    }
}
