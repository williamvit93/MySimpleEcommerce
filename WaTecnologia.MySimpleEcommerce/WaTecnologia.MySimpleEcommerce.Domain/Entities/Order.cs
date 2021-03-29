using System;
using System.Collections.Generic;

namespace WaTecnologia.MySimpleEcommerce.Domain.Entities
{
    public class Order : EntityBase
    {
        public int CustomerId { get; private set; }
        public List<Product> Products { get; private set; }
        public decimal TotalPrice { get; private set; }
        public virtual Customer Customer { get; set; }

        public Order(int customerId, List<Product> products, decimal totalPrice, DateTime saleDate)
        {
            CustomerId = customerId;
            Products = products;
            TotalPrice = totalPrice;
            CreatedDate = saleDate;
        }

        protected Order()
        {

        }
    }
}
