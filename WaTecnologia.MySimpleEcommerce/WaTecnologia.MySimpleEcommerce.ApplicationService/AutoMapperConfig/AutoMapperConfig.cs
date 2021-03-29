using AutoMapper;
using WaTecnologia.MySimpleEcommerce.ApplicationService.ViewModels;
using WaTecnologia.MySimpleEcommerce.Domain.Entities;

namespace WaTecnologia.MySimpleEcommerce.ApplicationService.AutoMapperConfig
{
    public static class AutoMapperConfig
    {
        public static IMapper Register()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CustomerViewModel, Customer>().ReverseMap();
                cfg.CreateMap<ProductViewModel, Product>().ReverseMap();
                cfg.CreateMap<ProductPriceViewModel, ProductPrice>().ReverseMap();
                cfg.CreateMap<OrderViewModel, Order>().ReverseMap();
            });

            return config.CreateMapper();
        }
    }
}
