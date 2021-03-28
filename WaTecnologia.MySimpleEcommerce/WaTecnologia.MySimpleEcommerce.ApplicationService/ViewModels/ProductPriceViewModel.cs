using System;

namespace WaTecnologia.MySimpleEcommerce.ApplicationService.ViewModels
{
    public class ProductPriceViewModel : BaseViewModel
    {
        public int ProductId { get; private set; }
        public decimal Price { get; private set; }
        public virtual ProductViewModel Product { get; set; }
    }
}
