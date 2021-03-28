using AutoMapper;
using WaTecnologia.MySimpleEcommerce.ApplicationService.Interfaces;
using WaTecnologia.MySimpleEcommerce.ApplicationService.ViewModels;
using WaTecnologia.MySimpleEcommerce.Domain.Entities;
using WaTecnologia.MySimpleEcommerce.Repository.Repositories.Interfaces;

namespace WaTecnologia.MySimpleEcommerce.ApplicationService
{
    public class CustomersAppServices : BaseAppServices<Customer, CustomerViewModel>, ICustomerAppServices
    {
        public CustomersAppServices(IMapper mapper, IBaseRepository<Customer> baseRepository) : base(mapper, baseRepository)
        {
        }

        public void Add(CustomerViewModel customerViewModel)
        {
            customerViewModel.Active = true;
            base.Add(customerViewModel);
        }
    }
}
