using System;

namespace WaTecnologia.MySimpleEcommerce.Domain.Entities
{
    public class EntityBase
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
