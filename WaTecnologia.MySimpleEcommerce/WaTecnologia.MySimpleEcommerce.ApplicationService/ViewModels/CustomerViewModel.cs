using System;
using System.Collections.Generic;

namespace WaTecnologia.MySimpleEcommerce.ApplicationService.ViewModels
{
    public class CustomerViewModel : BaseViewModel
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string CPF { get; set; }
        public virtual List<OrderViewModel> Sales { get; set; }
    }
}
