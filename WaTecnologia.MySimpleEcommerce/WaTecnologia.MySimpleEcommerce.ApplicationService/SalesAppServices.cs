using AutoMapper;
using WaTecnologia.MySimpleEcommerce.ApplicationService.Interfaces;
using WaTecnologia.MySimpleEcommerce.ApplicationService.ViewModels;
using WaTecnologia.MySimpleEcommerce.Domain.Entities;
using WaTecnologia.MySimpleEcommerce.Repository.Repositories.Interfaces;

namespace WaTecnologia.MySimpleEcommerce.ApplicationService
{
    public class SalesAppServices : BaseAppServices<Sale, SaleViewModel>, ISalesAppServices
    {
        public SalesAppServices(IMapper mapper, IBaseRepository<Sale> baseRepository) : base(mapper, baseRepository)
        {
        }
    }
}
