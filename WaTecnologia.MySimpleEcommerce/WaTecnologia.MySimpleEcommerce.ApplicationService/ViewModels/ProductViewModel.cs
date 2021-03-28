using System.Collections.Generic;

namespace WaTecnologia.MySimpleEcommerce.ApplicationService.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        public string Description { get; set; }
        public List<ProductPriceViewModel> ProductPrices { get; set; }
        public virtual List<SaleViewModel> Sales { get; set; }
    }
}
