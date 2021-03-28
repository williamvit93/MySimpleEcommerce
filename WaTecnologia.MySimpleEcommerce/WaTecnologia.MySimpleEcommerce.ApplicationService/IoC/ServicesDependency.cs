using Microsoft.Extensions.DependencyInjection;
using WaTecnologia.MySimpleEcommerce.ApplicationService.Interfaces;
using WaTecnologia.MySimpleEcommerce.ApplicationService.ViewModels;
using WaTecnologia.MySimpleEcommerce.Domain.Entities;
using WaTecnologia.MySimpleEcommerce.Repository.Repositories;
using WaTecnologia.MySimpleEcommerce.Repository.Repositories.Interfaces;

namespace WaTecnologia.MySimpleEcommerce.ApplicationService.IoC
{
    public static class ServicesDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            //AutoMapper
            services.AddSingleton(AutoMapperConfig.AutoMapperConfig.Register());

            //AppServices
            services.AddTransient<IBaseAppServices<Customer, CustomerViewModel>, BaseAppServices<Customer, CustomerViewModel>>();
            services.AddTransient<IBaseAppServices<Product, ProductViewModel>, BaseAppServices<Product, ProductViewModel>>();
            services.AddTransient<IBaseAppServices<ProductPrice, ProductPriceViewModel>, BaseAppServices<ProductPrice, ProductPriceViewModel>>();
            services.AddTransient<IBaseAppServices<Sale, SaleViewModel>, BaseAppServices<Sale, SaleViewModel>>();

            services.AddTransient<ICustomerAppServices, CustomersAppServices>();
            services.AddTransient<IProductsAppServices, ProductsAppServices>();
            services.AddTransient<IProductPricesAppServices, ProductPricesAppService>();
            services.AddTransient<ISalesAppServices, SalesAppServices>();

            //Repositories
            services.AddTransient<IBaseRepository<Customer>, BaseRepository<Customer>>();
            services.AddTransient<IBaseRepository<Product>, BaseRepository<Product>>();
            services.AddTransient<IBaseRepository<ProductPrice>, BaseRepository<ProductPrice>>();
            services.AddTransient<IBaseRepository<Sale>, BaseRepository<Sale>>();

            services.AddTransient<ICustomersRepository, CustomersRepository>();
            services.AddTransient<IProductsRepository, ProductsRepository>();
            services.AddTransient<IProductPricesRepository, ProductPricesRepository>();
            services.AddTransient<ISalesRepository, SalesRepository>();
        }
    }
}
