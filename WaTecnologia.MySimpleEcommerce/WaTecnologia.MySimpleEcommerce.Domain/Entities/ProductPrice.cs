using System;

namespace WaTecnologia.MySimpleEcommerce.Domain.Entities
{
    public class ProductPrice : EntityBase
    {
        public int ProductId { get; private set; }
        public decimal Price { get; private set; }
        public virtual Product Product { get; set; }

        public ProductPrice(int productId, decimal price)
        {
            ProductId = productId;
            Price = price;
        }

        protected ProductPrice()
        {

        }
    }
}
