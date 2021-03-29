using System;
using System.Collections.Generic;

namespace WaTecnologia.MySimpleEcommerce.ApplicationService.ViewModels
{
    public class OrderViewModel : BaseViewModel
    {
        public int CustomerId { get; set; }
        public List<ProductViewModel> Products { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual CustomerViewModel Customer { get; set; }
    }
}
