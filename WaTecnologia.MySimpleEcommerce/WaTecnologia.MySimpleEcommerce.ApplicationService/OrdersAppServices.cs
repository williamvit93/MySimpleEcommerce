using AutoMapper;
using WaTecnologia.MySimpleEcommerce.ApplicationService.Interfaces;
using WaTecnologia.MySimpleEcommerce.ApplicationService.ViewModels;
using WaTecnologia.MySimpleEcommerce.Domain.Entities;
using WaTecnologia.MySimpleEcommerce.Repository.Repositories.Interfaces;

namespace WaTecnologia.MySimpleEcommerce.ApplicationService
{
    public class OrdersAppServices : BaseAppServices<Order, OrderViewModel>, IOrdersAppServices
    {
        public OrdersAppServices(IMapper mapper, IBaseRepository<Order> baseRepository) : base(mapper, baseRepository)
        {
        }
    }
}
