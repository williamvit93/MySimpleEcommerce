using System;
using System.Collections.Generic;

namespace WaTecnologia.MySimpleEcommerce.Domain.Entities
{
    public class Product : EntityBase
    {
        public string Description { get; private set; }
        public List<ProductPrice> ProductPrices { get; set; }
        public virtual List<Order> Orders { get; set; }

        public Product(string description)
        {
            Description = description;
        }

        protected Product()
        {

        }
    }
}
