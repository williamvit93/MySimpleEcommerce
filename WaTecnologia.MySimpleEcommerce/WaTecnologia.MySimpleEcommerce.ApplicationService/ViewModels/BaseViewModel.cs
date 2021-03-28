using System;

namespace WaTecnologia.MySimpleEcommerce.ApplicationService.ViewModels
{
    public class BaseViewModel
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
